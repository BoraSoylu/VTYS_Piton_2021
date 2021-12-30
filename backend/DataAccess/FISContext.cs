using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class FISContext : DbContext
    {
        //public FISContext(DbContextOptions<FISContext> options)
        //    : base(options)
        //{
            
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            base.OnConfiguring(ob);
        }

        public DbSet<Citizen> Citizens { get; set; }




    }
}
