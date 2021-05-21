using System;
using System.Collections.Generic;
using System.Text;

namespace GamePicker
{
    /// <summary>
    /// A Game object specific to Hobo Night
    /// </summary>
    public class HoboNightGame : Game
    {
        /// <summary>
        /// The last time the game was picked for a hobo night
        /// </summary>
        public DateTime LastPicked;

        public HoboNightGame(string name = null, int players = 1, int platforms = 0, params string[] tags) : base(name, players, platforms, tags)
        {
            LastPicked = DateTime.MinValue;
        }

        public HoboNightGame() : base()
        {
            LastPicked = DateTime.MinValue;
        }
    }
}
