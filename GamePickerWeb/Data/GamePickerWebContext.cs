using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GamePicker;

namespace GamePickerWeb.Data
{
    public class GamePickerWebContext : DbContext
    {
        public GamePickerWebContext (DbContextOptions<GamePickerWebContext> options)
            : base(options)
        {
        }

        public DbSet<GamePicker.GameModel> GameModel { get; set; } = default!;
    }
}
