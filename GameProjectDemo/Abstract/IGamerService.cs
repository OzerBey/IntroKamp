using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    interface IGamerService
    {
        bool Add(User user);
        void Update(User user);
        void Delete(User user); 

    }
}
