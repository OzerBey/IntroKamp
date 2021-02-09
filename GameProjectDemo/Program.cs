using System;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new User()
            { Id = 1, FirstName = "Yasin", LastName = "Özer", BirthYear = 1998, NationalityIdentity = 12345 });

        }
    }
}
