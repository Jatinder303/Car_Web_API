using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_API.Model;

namespace Web_API.Models
{
    public class Car_APIContext : DbContext
    {
        public Car_APIContext (DbContextOptions<Car_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Web_API.Model.Car> Car { get; set; }
    }
}
