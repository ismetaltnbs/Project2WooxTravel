using Project2WooxTravel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project2WooxTravel.Context
{
    public class TravelContext : DbContext 
     // DbContext -> -Code first yönteminde sql'e yansıyacak tabloların olduğu kısım
    {
        public DbSet<Category> Categories { get; set; } //Category entity'nin entities'e dönüşmesini sağlıyoruz.
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
    }
}