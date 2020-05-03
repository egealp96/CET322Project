using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EgeAlpProject.Models;


namespace EgeAlpProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Member> Members { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        { }

    }
}
