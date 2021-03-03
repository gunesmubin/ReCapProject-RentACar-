using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.ValidationRules.FluentValidator
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MaximumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(100).When(c=>c.BrandId==1);
            //RuleFor(c => c.Description).Must(StartWithA).WithMessage("Araçlar A harfi ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
