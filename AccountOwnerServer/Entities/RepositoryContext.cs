using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Entities;


namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    //var connectionString = config["sqlserverconnection:connectionString"];

        //    options.UseSqlServer(@"Server = DESKTOP-RQBKGG3; Database = accountowner; Trusted_connection = yes");
        //}

        public DbSet<Owner>? Owners { get; set; }
        public DbSet<Account>? Accounts { get; set; }
    }
}
