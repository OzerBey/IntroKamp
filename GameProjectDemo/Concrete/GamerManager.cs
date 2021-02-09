using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{

    class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public bool Add(User user)
        {
            if (_userValidationService.validate(user))
            {
                Console.WriteLine("Valiadation successful !");
                return true;
            }
            else
            {
                Console.WriteLine("Validation unsuccessful !!"); 
                return false;
            }
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}
