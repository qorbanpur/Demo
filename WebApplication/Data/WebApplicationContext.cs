using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.DtoModels;

namespace WebApplication.Models
{
    public class WebApplicationContext : DbContext
    {
        public WebApplicationContext (DbContextOptions<WebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication.DtoModels.UserDto> UserDto { get; set; }

        public DbSet<WebApplication.DtoModels.SubscriptionDto> SubscriptionDto { get; set; }
    }
}
