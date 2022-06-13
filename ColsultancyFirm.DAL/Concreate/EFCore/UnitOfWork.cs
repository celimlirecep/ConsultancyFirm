using ColsultancyFirm.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Concreate.EFCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ConsultantFirmContext _context;

        public UnitOfWork(ConsultantFirmContext context)
        {
            _context = context;
        }
        private  EFCoreAuthorRepository _authorRepository;
        private  EFCoreCategoryRepository _categoryRepository;
        private EFCoreHeadingRepository _headingRepository;
        private EFCoreHomeSliderRespository _homeSliderRespository;
        private  EFCoreMemberServiceRepository _memberServiceRepository;
        private  EFCoreMessageRepository _messageRepository;

        public ICategoryRepository Categories => _categoryRepository=_categoryRepository ?? new EFCoreCategoryRepository(_context);

        public IAuthorRepository Authors => _authorRepository=_authorRepository?? new EFCoreAuthorRepository(_context);

        public IHeadingRepository Headings => _headingRepository=_headingRepository?? new EFCoreHeadingRepository(_context);

        public IHomeSliderRepository HomeSliders => _homeSliderRespository=_homeSliderRespository??new EFCoreHomeSliderRespository(_context);

        public IMemberServiceRepository MemberServices => _memberServiceRepository=_memberServiceRepository?? new EFCoreMemberServiceRepository(_context);

        public IMessageRepository Messages => _messageRepository=_messageRepository?? new EFCoreMessageRepository(_context);

        public void Dispose()
        {
            _context.Dispose() ;
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
