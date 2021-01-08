using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.EF
{
    public class POSDBContextFactory : IDesignTimeDbContextFactory<POSDBContext>
    {
        public POSDBContext CreateDbContext(string[] args=null)
        {
            var options = new DbContextOptionsBuilder<POSDBContext>();

            options.UseSqlServer("Server=.;Database=POSDB;Trusted_Connection=True");

            return new POSDBContext(options.Options);
          
        }
    }
}
