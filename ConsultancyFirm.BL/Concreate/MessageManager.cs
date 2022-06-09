using ColsultancyFirm.DAL.Abstract;
using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Concreate
{
    public class MessageManager : IMessageService
    {
        private IMessageRepository _messageRepository;

        public MessageManager(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public void Add(Message entity)
        {
            _messageRepository.Add(entity);
        }

        public void Delete(Message entity)
        {
            _messageRepository.Delete(entity);
        }

        public List<Message> Get(Expression<Func<Message, bool>> filter)
        {
            return _messageRepository.Get(filter);
        }

        public List<Message> GetAll()
        {
          return  _messageRepository.GetAll();
        }

        public Message GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Message GetSingle(Expression<Func<Message, bool>> filter)
        {
            return _messageRepository.GetSingle(filter);
        }

        public void Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
