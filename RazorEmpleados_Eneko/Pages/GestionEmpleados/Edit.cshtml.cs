using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorEmpleados_Eneko.Models;

namespace RazorEmpleados_Eneko.Pages.GestionEmpleados
{
    public class EditModel : PageModel
    {
        private readonly RazorEmpleados_Eneko.Models.RazorEmpleados_EnekoContext _context;

        public EditModel(RazorEmpleados_Eneko.Models.RazorEmpleados_EnekoContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Empleados).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadosExists(Empleados.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmpleadosExists(int id)
        {
            return _context.Empleados.Any(e => e.ID == id);
        }
    }
}
