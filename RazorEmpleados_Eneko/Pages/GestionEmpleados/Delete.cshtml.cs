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
    public class DeleteModel : PageModel
    {
        private readonly RazorEmpleados_Eneko.Models.RazorEmpleados_EnekoContext _context;

        public DeleteModel(RazorEmpleados_Eneko.Models.RazorEmpleados_EnekoContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Empleados = await _context.Empleados.FindAsync(id);

            if (Empleados != null)
            {
                _context.Empleados.Remove(Empleados);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
