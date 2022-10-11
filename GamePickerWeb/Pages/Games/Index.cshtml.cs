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
    public class IndexModel : PageModel
    {
        private readonly GamePickerWeb.Data.GamePickerWebContext _context;

        public IndexModel(GamePickerWeb.Data.GamePickerWebContext context)
        {
            _context = context;
        }

        public IList<GameModel> GameModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.GameModel != null)
            {
                GameModel = await _context.GameModel.ToListAsync();
            }
        }
    }
}
