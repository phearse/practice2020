using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql;
namespace Practice.Models
{
    public class TeachersContext : DbContext
    {
        public TeachersContext(DbContextOptions<TeachersContext> options)
            : base(options)
        {
        }

    public DbSet<Teachers> Teachers { get; set; }
    }
}
