using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Webvendas.Models;

namespace Webvendas.Data
{
    public class WebvendasContext : DbContext
    {
        public WebvendasContext (DbContextOptions<WebvendasContext> options)
            : base(options)
        {
        }

        public DbSet<Webvendas.Models.Department> Department { get; set; }
    }
}
