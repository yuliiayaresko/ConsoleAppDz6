using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppDz6
{
    public class PublishingHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    }

    public class Pidruchnuk
    {
        public int PublishingHouseId { get; set; }
        public string Title { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
    }





}

