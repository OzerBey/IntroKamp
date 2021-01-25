using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Entities;

namespace RecapPlayerDemo.Abstract
{
    interface IGameManager
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void Release(Game game);
        void GameSale(Game game);
    }
}
