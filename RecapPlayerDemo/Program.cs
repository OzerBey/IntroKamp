using System;
using System.Collections.Generic;
using RecapPlayerDemo.Abstract;
using RecapPlayerDemo.Concrete;
using RecapPlayerDemo.Entities;

namespace RecapPlayerDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            List<Player> players = new List<Player>();

            Player person1 = new Player() { Id = 1, FirstName = "Yasin", LastName = "Özer", NationalityId = "123456789", DateOfBirth = 1998, Password = "231" };
            Customer person2 = new Player() { Id = 2, FirstName = "Zeynep Nur", LastName = "Özer", NationalityId = "987654321", DateOfBirth = 2013, UserName = "Lucky", Password = "321" };
            Customer person3 = new Player() { Id = 3, FirstName = "Ali", LastName = "Soydan", NationalityId = "213546956", DateOfBirth = 1995, UserName = "Fury", Password = "123" };

            Customer[] customers = new Customer[] { person1, person2, person3 };

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(person1);
            playerManager.Add(person2);
            playerManager.Add(person3);

            GameManager gameManager = new GameManager();
            Game game1 = new Game() { Id = 1, Name = "Call of Duty", Type = "War", Version = "1.30", Price = 469, ReleaseYear = 2007 };
            Game game2 = new Game() { Id = 2, Name = "Rocket League", Type = "Entertainment", Version = "1.55", Price = 0, ReleaseYear = 2016 };
            Game game3 = new Game() { Id = 2, Name = "Mad Max", Type = "War", Version = "2.1", Price = 15, ReleaseYear = 2015 };
            gameManager.Add(game1);
            gameManager.Add(game2);
            //studentSale
            ICampaignManager campaignManager1 = new StudentCampaign();
            //seasonSale
            ICampaignManager campaignManager2 = new SeasonCampaign();

            campaignManager1.Calculate(game1);
            campaignManager2.Calculate(game2);


            /*
                 Console MENU
            
                         bool val = true;
            while (val)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Add player\n" +
                                  "2. Delete player\n" +
                                  "3. Update player\n" +
                                  "4. List the players\n" +
                                  "5. Add game\n" +
                                  "6. Delete game\n" +
                                  "7. Update game\n" +
                                  "8. Release of game\n" +
                                  "9. Sale of game\n" +
                                  "10. Select campaign for you\n" +
                                  "-1. Exit the menu\n");
                Console.WriteLine("-----------------------------");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Enter your username");
                        string _UserName = Console.ReadLine();
                        Console.WriteLine("Enter your password");
                        string _Password = Console.ReadLine();
                        Console.WriteLine("Enter your Nationality Id:");
                        string _NationalityId = Console.ReadLine();
                        Console.WriteLine("Name: ");
                        string _FirstName = Console.ReadLine();
                        Console.WriteLine("Lastname:");
                        string _LastName = Console.ReadLine();
                        Console.WriteLine("Date of birth: ");
                        int _DateOfBirth = Convert.ToInt32(Console.ReadLine());
                        playerManager.Add(new Player() { UserName = _UserName, Password = _Password, FirstName = _FirstName, LastName = _LastName, DateOfBirth = _DateOfBirth, NationalityId = _NationalityId });
                        break;
                    case 2:
                        Console.WriteLine("Enter your Id for Delete");
                        int _Id = Convert.ToInt32(Console.ReadLine());
                        playerManager.Delete(person1, _Id);
                        break;
                    case 3:
                        Console.WriteLine("Enter your Id for Update");
                        //int _Id = Convert.ToInt32(Console.ReadLine());
                        playerManager.Update(person1);
                        break;
                    case 4:
                        playerManager.ShowList(customers);
                        break;
                    case 5:
                        gameManager.Add(game1);

                        break;
                    case 6:
                        gameManager.Delete(game2);
                        break;
                    case 7:
                        gameManager.Update(game1);
                        break;
                    case 8:
                        gameManager.Release(game3);
                        break;
                    case 9:
                        gameManager.GameSale(game1);
                        break;
                    case 10:
                        Console.WriteLine("Select campaign");
                        break;
                    case -1:
                        val = false;
                        break;
                    default:
                        Console.WriteLine("Wrong key please enter again");
                        break;
                }
            }
            
             */

        }
    }
}
