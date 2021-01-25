using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Abstract;

namespace RecapPlayerDemo.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int ReleaseYear { get; set; }
        public string Version { get; set; }



    }
}
