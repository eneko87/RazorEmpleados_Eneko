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
    public class DetailsModel : PageModel
    {
        private readonly RazorEmpleados_Eneko.Models.RazorEmpleados_EnekoContext _context;

        public DetailsModel(RazorEmpleados_Eneko.Models.RazorEmpleados_EnekoContext context)
        {
            _context = context;
        }

        public Empleados Empleados { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Empleados = await _context.Empleados.FirstOrDefaultAsync(m => m.ID == id);

            if (Empleados == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
