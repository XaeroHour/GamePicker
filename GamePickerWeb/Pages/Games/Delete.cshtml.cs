using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GamePicker;
using GamePickerWeb.Data;

namespace GamePickerWeb.Pages.Games
{
    public class DeleteModel : PageModel
    {
        private readonly GamePickerWeb.Data.GamePickerWebContext _context;

        public DeleteModel(GamePickerWeb.Data.GamePickerWebContext context)
        {
            _context = context;
        }

        [BindProperty]
      public GameModel GameModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.GameModel == null)
            {
                return NotFound();
            }

            var gamemodel = await _context.GameModel.FirstOrDefaultAsync(m => m.Id == id);

            if (gamemodel == null)
            {
                return NotFound();
            }
            else 
            {
                GameModel = gamemodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.GameModel == null)
            {
                return NotFound();
            }
            var gamemodel = await _context.GameModel.FindAsync(id);

            if (gamemodel != null)
            {
                GameModel = gamemodel;
                _context.GameModel.Remove(GameModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
