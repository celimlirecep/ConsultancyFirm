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

        public async Task<IActionResult> Index()
        {
            User user = await _userManager.GetUserAsync(User);
            ViewBag.Author = new SelectList(_authorService.GetAll(), "AuthorId", "AuthorFullName");
            MessageModel messageModel = new MessageModel()
            {
                User = user,
                Authors = _authorService.GetAll(),
                Messages = _messageService.Get(i=>i.MessageTo==user.Email),
            };
            return View(messageModel);
        }
        public async Task<IActionResult> MessageSend(MessageModel model)
        {
            //From Mail
            var userFrom =await _userManager.GetUserAsync(User);

            //tO MAİL
            var author=_authorService.GetSingle(i => i.AuthorId == model.Author.AuthorId);
            var userTo=await _userManager.FindByIdAsync(author.UserId);
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
