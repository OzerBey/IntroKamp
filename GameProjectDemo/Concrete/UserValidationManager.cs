using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool validate(User user)
        {
            if (user.BirthYear == 1998 && user.FirstName == "Yasin" && user.LastName == "Özer" && user.NationalityIdentity == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
