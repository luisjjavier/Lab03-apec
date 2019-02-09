using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;

namespace Lab02.Models
{

    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.Username).NotNull().Length(10, 25);
            RuleFor(user => user.Password).NotNull();
            RuleFor(user => user.ConfirmPassword).NotNull().Equal(user => user.ConfirmPassword);
            RuleFor(user => user.Email).NotNull().EmailAddress();

        }
    }
}