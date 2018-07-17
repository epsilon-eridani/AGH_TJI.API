using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AGH_TJI.API.Models
{
    public partial class AGH_DemoContext : DbContext
    {
        public AGH_DemoContext(DbContextOptions<AGH_DemoContext> options) : base(options)
        {

        }
        public virtual DbSet<People> People { get; set; }

    }
}
