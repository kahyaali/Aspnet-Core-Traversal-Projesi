﻿using EntityLayer.Concreate; // About sınıfını kullanabilmek için bu kütüphaneyi ekledik
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        // yapıcı metot oluşturduk
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmını Boş Geçemezsiniz!!!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen En Az 50 Karakter Açıklama Bilgisi Giriniz");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Açıklama 1500 Karakteri Geçemez");
        }
    }
}