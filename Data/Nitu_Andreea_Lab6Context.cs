using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nitu_Andreea_Lab6.Models;

namespace Nitu_Andreea_Lab6.Data
{
    public class Nitu_Andreea_Lab6Context : DbContext
    {
        public Nitu_Andreea_Lab6Context (DbContextOptions<Nitu_Andreea_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Nitu_Andreea_Lab6.Models.Book> Book { get; set; }
    }
}
