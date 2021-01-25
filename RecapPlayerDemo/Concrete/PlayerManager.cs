using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Abstract;
using RecapPlayerDemo.Entities;

namespace RecapPlayerDemo.Concrete
{
    class PlayerManager :ICustomerManager
    {
        //List<Player> players = new List<Player>() { };
        public void Add(Customer player)
        {
            Console.WriteLine(player.FirstName + " added");
        }

        public void Update(Customer player)
        {
            Console.WriteLine(player.FirstName + " updated");
        }

        public void Delete(Customer player,int id)
        {
            //foreach (var item in players)
            //{
            //    if (player.Id ==id )
            //    {
            //        players.Remove(players[id]);
            //        Console.WriteLine(player.FirstName+" "+ player.LastName+" deleted");
            //        break;
            //    }

            //    else
            //    {
            //        continue;
            //    }
            //}
            Console.WriteLine(player.Id + "=>" + player.FirstName + " deleted");
        }

        public void ShowList(Customer[] players)
        {
            foreach (var player in players)
            {
                Console.WriteLine("Name: " + player.FirstName + " LastName: " + player.LastName + " Year of Birth: " + player.DateOfBirth + " Nationality Id: " + player.NationalityId);
            }
        }
    }
}
