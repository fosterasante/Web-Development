using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.ClassLibrary.Models
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {

        AppDbContext IDesignTimeDbContextFactory<AppDbContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=JOHNSON\\SQLEXPRESS;Database=School;Trusted_Connection=True;Persist Security Info=False");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
