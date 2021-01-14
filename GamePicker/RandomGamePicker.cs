using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamePicker
{
    public static class RandomGamePicker
    {
        static readonly Random randomizer = new Random((int)DateTime.Now.ToBinary());

        public static GameLibrary _fullRandomLibrary = new GameLibrary();

        public static GameLibrary FullRandomLibrary => _fullRandomLibrary;

        public static Game SelectRandomGame(int supportedPlayers = 1, bool enforcePlayerCount = false, int supportedPlatforms = 0, params string[] requriedTags)
        {
            Game[] candidates = FullRandomLibrary.Library.Where(game => enforcePlayerCount ? game.SupportedPlayers == supportedPlayers  : game.SupportedPlayers >= supportedPlayers &&
                game.SupportsPlatforms(supportedPlatforms) &&
                game.ContainsTags(requriedTags)).ToArray();

            if(candidates.Length == 0)
            {
                throw new Exception("Unable to find candidates with given criteria");
            }

            return candidates[randomizer.Next() % candidates.Length];
        }

        public static void ConfirmGameSelection(HoboNightGame selectedGame) => selectedGame.LastPicked = DateTime.Now;

        public static void AddGame(Game game)
        {
            FullRandomLibrary.AddGame(game);
        }

        public static Game FindGame(string name) => FullRandomLibrary.Library.Where(game => string.Equals(game.Name, name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

        public static string[] GameList => FullRandomLibrary.Library.Select(game => game.Name).ToArray();
    }
}
