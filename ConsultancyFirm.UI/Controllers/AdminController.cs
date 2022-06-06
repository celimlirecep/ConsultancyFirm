using ConsultancyFirm.UI.Identity;
using ConsultancyFirm.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class AdminController : Controller
    {

        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;

        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            this._roleManager = roleManager;
            this._userManager = userManager;
        }

        public async Task<IActionResult> AdminPage()
        {

            var advisors = await _userManager.GetUsersInRoleAsync("Advisor");
            var regularUsers = await _userManager.GetUsersInRoleAsync("User");
            DashBoardModel dashBoardModel = new DashBoardModel()
            {
                TotalUsers = _userManager.Users.Count(),
                TotalAdvisors = advisors.Count(),
                TotalRegularUsers = regularUsers.Count()
            };

            return View(dashBoardModel);
        }
        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(string RoleName)
        {
            var result = await _roleManager.CreateAsync(new IdentityRole(RoleName));
            if (result.Succeeded)
            {
                return RedirectToAction("RoleList");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View();
        }
        public IActionResult RoleList()
        {

            return View(_roleManager.Roles);
        }
        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            return View(role);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(IdentityRole role)
        {
            IdentityRole edittingRole = await _roleManager.FindByIdAsync(role.Id);
            edittingRole.Name = role.Name;
            var result = await _roleManager.UpdateAsync(edittingRole);
            if (result.Succeeded)
            {
                return RedirectToAction("RoleList");
            }
            return View(role);


        }
        public async Task<IActionResult> RoleDelete(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            await _roleManager.DeleteAsync(role);
            return RedirectToAction("RoleList");
        }
        public async Task<IActionResult> RoleAssign()
        {
            List<User> userList = _userManager.Users.ToList();
            List<IdentityRole> roleList = _roleManager.Roles.ToList();
            List<UserRolesModel> userRoleList = new List<UserRolesModel>();

            foreach (var user in userList)
            {


                userRoleList.Add(new UserRolesModel()
                {
                    UserRoles = await _userManager.GetRolesAsync(user) as List<string>,
                    UserId = user.Id
                });
            }
            var model = new RoleAssignModel()
            {
                Rolls = roleList,
                Users = userList,
                UserRolesList = userRoleList

            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleAssign(RoleAssignModel model)
        {
            User user = await _userManager.FindByIdAsync(model.UserId);
            if (model.IsAdded)
            {
                if (!(await _userManager.IsInRoleAsync(user, model.RoleName)))
                {
                    await _userManager.AddToRoleAsync(user, model.RoleName);
                    return RedirectToAction("RoleAssign");
                }

            }
            if (await _userManager.IsInRoleAsync(user, model.RoleName))
            {
                await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                return RedirectToAction("RoleAssign");
            }



            return RedirectToAction("RoleAssign");
        }

        public IActionResult MemberList()
        {
            return View(_userManager.Users.ToList());
        }
        public IActionResult UserCreate()
        {
            var roles = _roleManager.Roles.Select(i => i.Name);
            ViewBag.Roles = roles;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserCreate(UserDetailsModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email,
                    EmailConfirmed = model.EmailConfirmed
                };
                var result = await _userManager.CreateAsync(user, "Qwe123.");
                if (result.Succeeded)
                {
                    selectedRoles = selectedRoles ?? new string[] { };
                    await _userManager.AddToRolesAsync(user, selectedRoles);
                    return Redirect("~/admin/MemberList");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                var roles = _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles;
                return View(model);
            }
            var roles2 = _roleManager.Roles.Select(i => i.Name);
            ViewBag.Roles = roles2;
            return View(model);
        }

        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                ViewBag.Roles = _roleManager.Roles.Select(i => i.Name);
                return View(new UserDetailsModel()
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SelectedRoles = selectedRoles
                });
            }
            return RedirectToAction("MemberList");
        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailsModel model, string[] selectedRoles)
        {
            var roles = _roleManager.Roles.Select(i => i.Name);
            ViewBag.Roles = roles;
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.EmailConfirmed = model.EmailConfirmed;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded && selectedRoles != null)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles).ToArray<string>());
                        return RedirectToAction("MemberList");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
                ModelState.AddModelError("", "Böyle bir kullanıcı yok!");
                return View(model);
            }
            return View(model);
        }

        public async Task<IActionResult> UserDelete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamamıştır");
                return RedirectToAction("MemberList");
            }
            var rollers = await _userManager.GetRolesAsync(user);

            if (rollers != null)
            {
                var result = await _userManager.RemoveFromRolesAsync(user, rollers.ToArray<string>());
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Sistemde bir hata oluştu daha sonra tekrar deneyiniz!");
                    return RedirectToAction("MemberList");
                }
            }

            user.EmailConfirmed = false;
            user.Id = user.Id;
            user.FirstName = user.FirstName;
            user.LastName = user.LastName;
            user.UserName = user.UserName;
            user.Email = user.Email;
            var userUpdateResult = await _userManager.UpdateAsync(user);
            if (!userUpdateResult.Succeeded)
            {
                ModelState.AddModelError("", "Sistemde bir hata oluştu daha sonra tekrar deneyiniz!");
                return RedirectToAction("MemberList");
            }

            return RedirectToAction("MemberList");

        }


    }
}
