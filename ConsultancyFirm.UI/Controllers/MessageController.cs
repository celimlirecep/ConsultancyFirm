using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.EL;
using ConsultancyFirm.UI.Identity;
using ConsultancyFirm.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class MessageController : Controller
    {
        private UserManager<User> _userManager;
        private IAuthorService _authorService;
        private IMessageService _messageService;

        public MessageController(UserManager<User> userManager, IAuthorService authorService, IMessageService messageService)
        {
            _userManager = userManager;
            _authorService = authorService;
            _messageService = messageService;
        }

        //default gelen mailler IsReciveMail true olursa gönderilenler açılacak
        public async Task<IActionResult> Index(bool IsReciveMail)
        {
            User user = await _userManager.GetUserAsync(User);
           
           
            if (await _userManager.IsInRoleAsync(user,"Advisor") || await _userManager.IsInRoleAsync(user, "Admin"))
            {
                ViewBag.ToMail = new SelectList(_userManager.Users, "Id", "UserFullName");
            }
            else
            {
                ViewBag.ToMail = new SelectList( await _userManager.GetUsersInRoleAsync("Advisor"), "Id", "UserFullName");
            }
           
            MessageModel messageModel = new MessageModel()
            {
                User = user,
               
                Messages = IsReciveMail? _messageService.Get(i => i.MessageFrom == user.Email) : _messageService.Get(i=>i.MessageTo==user.Email),
            };
            return View(messageModel);
        }
        public async Task<IActionResult> MessageSend(MessageModel model)
        {
            //From Mail
            var userFrom =await _userManager.GetUserAsync(User);

            //tO MAİL

            var userTo = await _userManager.FindByIdAsync(model.User.Id);
            
            Message message = new Message()
            {
                MessageFrom = userFrom.Email,
                MessageTo = userTo.Email,
                MessageTitle = model.Message.MessageTitle,
                MessageContent = model.Message.MessageContent,
                MessageSendDate = DateTime.Parse(DateTime.Now.ToShortDateString())
            };
            _messageService.Add(message);

            return RedirectToAction("Index");
        }
        
    }
}
