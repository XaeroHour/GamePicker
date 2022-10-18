using GamePicker;
using GamePickerWeb.Data;
using GamePickerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GamePickerWeb.Pages
{
    public class DailyGameModel : PageModel
    {
        public const int HourForReset = 17;

        [BindProperty(Name = "Selected Game")]
        public string DailyPickedGame { get; private set; } = $"No Game Selected yet, come back in {HourForReset - DateTime.Now.Hour} hours or so";

        [BindProperty]
        public string[] SelectedGames { get; set; }

        [BindProperty]
        public string[] SelectedHatGames { get; set; }

        public SelectList SelectedGamesList { get; set; } = null;

        public SelectList HatGamesList { get; set; } = null;

        private readonly GamePickerWebContext _context;

        public DailyGameModel(GamePickerWebContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            SelectedGamesList = new SelectList(_context.GameModel.Select(game => game.Title));
            HatGamesList = new SelectList(_context.DailyGameCandidateModel.Select(g => g.GameName));
            CheckForGameTime();
        }

        public void OnPost()
        {
            // Make sure the selected games list gets repopulated
            SelectedGamesList = new SelectList(_context.GameModel.Select(game => game.Title));

            foreach (string removeGameName in SelectedHatGames)
            {
                DailyGameCandidateModel? remove = _context?.DailyGameCandidateModel.Where(g => g.GameName == removeGameName)?.FirstOrDefault();
                if (_context != null && remove != null)
                {
                    _context.DailyGameCandidateModel.Remove(remove);
                }
            }

            foreach (string candidateName in SelectedGames)
            {
                if (_context.DailyGameCandidateModel.Any(g => g.GameName == candidateName))
                {
                    continue;
                }

                _context.DailyGameCandidateModel.Add(new DailyGameCandidateModel()
                {
                    GameName = candidateName,
                });
            }

            _context.SaveChanges();
            HatGamesList = new SelectList(_context.DailyGameCandidateModel.Select(g => g.GameName));

            if (_context == null)
            {
                throw new ArgumentNullException("Context is null");
            }

            CheckForGameTime();
        }

        private void CheckForGameTime()
        {
            if (_context.PickedGameModel.Where(g => g.DateTimePicked.Date == DateTime.Now.Date)?.FirstOrDefault() == null)
            {
                // If we haven't picked a game for today and it's after 5, pick the first game of the day
                if (DateTime.Now.Hour >= HourForReset)
                {
                    if (_context.DailyGameCandidateModel == null || _context.DailyGameCandidateModel.Count() < 1)
                    {
                        DailyPickedGame = RandomGamePicker.SelectRandomGameEqualWeights()?.Title ?? String.Empty;
                    }
                    else
                    {
                        DailyPickedGame = RandomGamePicker.SelectRandomGameEqualWeights(_context.DailyGameCandidateModel.Select(g => g.GameName).ToArray())?.Title
                            ?? String.Empty;
                    }

                    if (!string.IsNullOrEmpty(DailyPickedGame))
                    {
                        _context.GameModel.Where(g => g.Title == DailyPickedGame).FirstOrDefault().LastPlayed = DateTime.Now;
                        _context.PickedGameModel.Add(new PickedGameModel()
                        {
                            GameName = DailyPickedGame,
                            DateTimePicked = DateTime.Now.Date,
                        });

                        // remove everything from the hat for the next day
                        _context.DailyGameCandidateModel.RemoveRange(_context.DailyGameCandidateModel);
                        _context.SaveChanges();
                    }
                }
            }
        }
    }
}
