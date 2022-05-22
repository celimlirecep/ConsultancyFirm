using ConsultancyFirm.EL;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.ValidationRules
{
    public class MemberValidator:AbstractValidator<Member>
    {
        //public MemberValidator()
        //{
        //    RuleFor(x => x.MemberName).NotEmpty().WithMessage("Yazar adı boş bırakılamaz!");
        //    RuleFor(x => x.MemberSurname).NotEmpty().WithMessage("Yazar soyadı açıklaması boş bırakılamaz!");

        //    //RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında bölümü boş bırakılamaz!");
        //    ////  RuleFor(x => x.WriterName).Must(x=>x.Contains("s"));

        //    //RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("50 karakterden fazla değer girişi yapmayınız!");
        //    //RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("2 karakterden fazla değer girişi yapınız!");

        //}
    }
}
