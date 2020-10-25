using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorEmpleados_Eneko.Models;

namespace RazorEmpleados_Eneko.Pages.GestionEmpleados
{
    public class CreateModel : PageModel
    {
        private readonly RazorEmpleados_Eneko.Models.RazorEmpleados_EnekoContext _context;

        public CreateModel(RazorEmpleados_Eneko.Models.RazorEmpleados_EnekoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Empleados Empleados { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Empleados.Add(Empleados);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}