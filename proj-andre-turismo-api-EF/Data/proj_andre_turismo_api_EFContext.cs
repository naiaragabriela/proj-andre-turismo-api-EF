using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proj_andre_turismo_api_EF.Models;

namespace proj_andre_turismo_api_EF.Data
{
    public class proj_andre_turismo_api_EFContext : DbContext
    {
        public proj_andre_turismo_api_EFContext (DbContextOptions<proj_andre_turismo_api_EFContext> options)
            : base(options)
        {
        }

        public DbSet<proj_andre_turismo_api_EF.Models.City> City { get; set; } = default!;
    }
}
