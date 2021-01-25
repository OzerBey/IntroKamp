using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Abstract;
using RecapPlayerDemo.Entities;

namespace RecapPlayerDemo.Concrete
{
    class GameManager:IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("Id: "+game.Id+" Name: "+game.Name+" V"+game.Version+ " added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Id: " + game.Id + " Name: " + game.Name + " V" + game.Version + " deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Id: " + game.Id + " Name: " + game.Name + " V" + game.Version + " updated");
        }

        public void Release(Game game)
        {
            Console.WriteLine("Id: " + game.Id + " Name: " + game.Name + " V" + game.Version + " released");
        }

        public void GameSale(Game game)
        {
            Console.WriteLine("Price: "+game.Price);
        }
    }
}
