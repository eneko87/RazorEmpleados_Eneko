using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorEmpleados_Eneko.Models;

namespace RazorEmpleados_Eneko.Pages.GestionEmpleados
{
    public class IndexModel : PageModel
    {
        private readonly RazorEmpleados_Eneko.Models.RazorEmpleados_EnekoContext _context;

        public IndexModel(RazorEmpleados_Eneko.Models.RazorEmpleados_EnekoContext context)
        {
            _context = context;
        }

        public IList<Empleados> Empleados { get;set; }

        public async Task OnGetAsync()
        {
            Empleados = await _context.Empleados.ToListAsync();
        }
    }
}
