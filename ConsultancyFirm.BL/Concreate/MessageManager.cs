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
        private readonly IUnitOfWork _unitOfWork;
        public MessageManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Message entity)
        {
            _unitOfWork.Messages.Add(entity);
            _unitOfWork.save();
        }

        public void Delete(Message entity)
        {
            _unitOfWork.Messages.Delete(entity);
            _unitOfWork.save();
        }

        public List<Message> Get(Expression<Func<Message, bool>> filter)
        {
            return _unitOfWork.Messages.Get(filter);
        }

        public List<Message> GetAll()
        {
          return _unitOfWork.Messages.GetAll();
        }

        public Message GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Message GetSingle(Expression<Func<Message, bool>> filter)
        {
            return _unitOfWork.Messages.GetSingle(filter);
        }

        public void Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
