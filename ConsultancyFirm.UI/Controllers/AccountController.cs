using ConsultancyFirm.Core;
using ConsultancyFirm.UI.EmailServices;
using ConsultancyFirm.UI.Identity;
using ConsultancyFirm.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public IActionResult Login(LoginModel model=null)
        {
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginModel model,IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("login", model);
            }
         
            string image = file != null ? JobManager.UploadImage(file, "users") : "/images/users/default.png";
            
            User user = new User()
            {
                FirstName = model.Name,
                LastName = model.Surname,
                UserName = model.UserName,
                Email = model.Email,
                MemberImage = image
            };
            var result = await _userManager.CreateAsync(user, model.Password);//tabloya kaydet
            //sorun oluşması durumunda serverda
            if (!result.Succeeded)
            {
                return RedirectToAction("login", model);
            }
            //mail onay işlemleri
            //token işlemleri

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);//token oluşturduk
            //kullanıcıın maili tıkladığında izliyeceği rotayı oluşturmuş olduk
            var url = Url.Action("ConfirmEmail", "Account", new { 
                userId=user.Id,
                token=token
            });
            //mail gönderme
            await _emailSender.SenderEmailAsync(model.Email, "PisikoBar Hesap Onaylama", $"Lütfen email hesabınızı onaylamak için <a href='https://localhost:5001{url}'>tıklayınız</a>");
            return RedirectToAction("login");
         
        }
        public async Task<IActionResult> ConfirmEmail(string userId,string token)
        {
            if (userId==null || token==null)//kayıtlı olmayan kullanıcı tarafından giriş yapılırsa
            {
                return Redirect("/Account/Login");
            }
            var user = await _userManager.FindByIdAsync(userId);
            //işlem başarılıysa
            if (user!=null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    return View();
                }
            }

         
            //Hesap onaylanamdıysa
            return Redirect("/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            if (!ModelState.IsValid)
            {
                
                return RedirectToAction("login", model);
            }

            var user = await _userManager.FindByNameAsync(model.LoginUserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!");
                return RedirectToAction("login",model);
            }

            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Hesabınız onaylı değil! Lütfen mail adresiniz kontrol ederek, onay işlemlerini tamamlayınız.");
                return RedirectToAction("login", model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.LoginPassword, true, false);
            if (result.Succeeded)
            {
                return RedirectToAction("MemberPage","Member",new { username = user.UserName });
            }
            ModelState.AddModelError("", "Kullanıcı adı ya da parola hatalı!");
            return RedirectToAction("login", model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("", "Lütfen geçerli bir mail adresi giriniz!");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user==null)
            {
                ModelState.AddModelError("", "Sistemde kayıtlı bir mail adresi giriniz!");
                return View();
            }
            var token =await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new { 
            
                token=token,
                userId=user.Id
            });
            await _emailSender.SenderEmailAsync(email,"PisikoBar Şifre değiştirme İşlemi", $"Parolanızı yeniden belirlemek için <a href='https://localhost:5001{url}'>tıklayınız.</a>");
            return RedirectToAction("Login");
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(new ResetPasswordModel {
                Token=token 
            });
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Lütfen bilgileri doğru bir şekilde giriniz");
                TempData["Message"] = JobManager.CreateMessage("Dikkat!", "Lütfen bilgileri doğru giriniz", "Warning");
                return View(model);
            }

            User user = await _userManager.FindByEmailAsync(model.Email);
            if (user==null)
            {
                TempData["Message"] = JobManager.CreateMessage("Dikkat!", "Sistemde kayıtlı mail adresi bulunamamıştır","Warning");
          
         
                return View(model);
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
          
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "İşleminizi şuanda gerçekleştiremiyoruz, daha sonra tekrar deneyiniz.");
                TempData["Message"] = JobManager.CreateMessage("Dikkat!", $"İşleminizi şuanda gerçekleştiremiyoruz, daha sonra tekrar deneyiniz. token={model.Token}", "Warning");
                return View();
            }
            return Redirect("/Account/login");

        }





    }
}
