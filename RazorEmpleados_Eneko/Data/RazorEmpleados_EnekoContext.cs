using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorEmpleados_Eneko.Models
{
    public class RazorEmpleados_EnekoContext : DbContext
    {
        public RazorEmpleados_EnekoContext (DbContextOptions<RazorEmpleados_EnekoContext> options)
            : base(options)
        {
        }

        public DbSet<RazorEmpleados_Eneko.Models.Empleados> Empleados { get; set; }
    }
}
