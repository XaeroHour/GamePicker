using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GamePicker;
using GamePickerWeb.Data;

namespace GamePickerWeb.Pages.Games
{
    public class EditModel : PageModel
    {
        private readonly GamePickerWeb.Data.GamePickerWebContext _context;

        public EditModel(GamePickerWeb.Data.GamePickerWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GameModel GameModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.GameModel == null)
            {
                return NotFound();
            }

            var gamemodel =  await _context.GameModel.FirstOrDefaultAsync(m => m.Id == id);
            if (gamemodel == null)
            {
                return NotFound();
            }
            GameModel = gamemodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GameModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameModelExists(GameModel.Id))
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

        private bool GameModelExists(int id)
        {
          return _context.GameModel.Any(e => e.Id == id);
        }
    }
}
