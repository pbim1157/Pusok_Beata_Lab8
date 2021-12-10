using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pusok_Beata_Lab8.Models;

namespace Pusok_Beata_Lab8.Data
{
    public class Pusok_Beata_Lab8Context : DbContext
    {
        public Pusok_Beata_Lab8Context (DbContextOptions<Pusok_Beata_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pusok_Beata_Lab8.Models.Book> Book { get; set; }
    }
}
