using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamePicker
{
    /// <summary>
    /// Used to pick a random game from a linked library of games
    /// </summary>
    public static class RandomGamePicker
    {
        /// <summary>
        /// Random number generator. Seeded with binary datetime.now
        /// </summary>
        static readonly Random randomizer = new Random((int)DateTime.Now.ToBinary());

        /// <summary>
        /// Get a random game from the library to play
        /// </summary>
        /// <param name="supportedPlayers">The number of players the game should support at minimum</param>
        /// <param name="enforcePlayerCount">If set to true, supportedPlayers will be used as an exact count rather than a minimum</param>
        /// <param name="supportedPlatforms">The platforms the game must support. If 0 is the same as all platforms</param>
        /// <param name="requriedTags">The tags the game must contain. If none are specified, any game can be selected.</param>
        /// <returns></returns>
        public static Game SelectRandomGame(int supportedPlayers = 1, bool enforcePlayerCount = false, int supportedPlatforms = 0, params string[] requriedTags)
        {
            Game[] candidates = GameLibrary.HoboGameLibrary.Where(game => enforcePlayerCount ? game.SupportedPlayers == supportedPlayers  : game.SupportedPlayers >= supportedPlayers &&
                game.SupportsPlatforms(supportedPlatforms) &&
                game.ContainsTags(requriedTags)).ToArray();

            if(candidates.Length == 0)
            {
                throw new Exception("Unable to find candidates with given criteria");
            }

            return candidates[randomizer.Next() % candidates.Length];
        }

        /// <summary>
        /// Set the last picked datetime for HoboNightGame
        /// </summary>
        /// <param name="selectedGame">The game selected</param>
        public static void ConfirmGameSelection(HoboNightGame selectedGame) => selectedGame.LastPicked = DateTime.Now;

        /// <summary>
        /// Add a game to the library
        /// </summary>
        /// <param name="game">The new game to add</param>
        public static void AddGame(Game game) => GameLibrary.AddGame(game);

        /// <summary>
        /// Find a given game matching the name
        /// </summary>
        /// <param name="name">The name of the game to find</param>
        /// <returns>Returns a Game object matching the name, or null if not found.</returns>
        public static Game FindGame(string name) => GameLibrary.HoboGameLibrary.Where(game => string.Equals(game.Name, name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

        /// <summary>
        /// The full list of game names in the library
        /// </summary>
        public static string[] GameList => GameLibrary.HoboGameLibrary.Select(game => game.Name).ToArray();
    }
}
