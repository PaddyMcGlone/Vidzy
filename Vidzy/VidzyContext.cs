using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidzy.Models;

namespace Vidzy
{
    public class VidzyContext : DbContext
    {
        public VidzyContext() : base("Name = VidzyConnection")
        {
        }

        public DbSet<Video> Videos { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}
