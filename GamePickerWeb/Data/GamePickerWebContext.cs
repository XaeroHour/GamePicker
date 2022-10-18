using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GamePicker;
using GamePickerWeb.Pages;
using GamePickerWeb.Models;

namespace GamePickerWeb.Data
{
    public class GamePickerWebContext : DbContext
    {
        public GamePickerWebContext (DbContextOptions<GamePickerWebContext> options)
            : base(options)
        {
        }

        public DbSet<GameModel> GameModel { get; set; } = default!;

        public DbSet<DailyGameCandidateModel> DailyGameCandidateModel { get; set; } = default!;

        public DbSet<PickedGameModel> PickedGameModel { get; set; } = default!;
    }
}
