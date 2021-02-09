using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    interface IUserValidationService
    {
        bool validate(User user); 
    }
}
