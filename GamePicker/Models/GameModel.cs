using System;
using System.Collections.Generic;
using System.Linq;

namespace HoboNightGamePickerWeb
{
    /// <summary>
    /// Enum containing bit codes for platforms
    /// </summary>
    public enum Platform
    {
        Xbox = 0x1,
        PlayStation = 0x2,
        Switch = 0x4,
        PC = 0x8,
        Mobile = 0x10
    }

    /// <summary>
    /// Game object
    /// </summary>
    public class GameModel
    {
        /// <summary>
        /// Title Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Game title. Sequels are different titles.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The number of players the game supports (6 is treated as 6+)
        /// </summary>
        public int SupportedPlayers { get; set; }

        /// <summary>
        /// Bit field containing supported platform information
        /// </summary>
        public int SupportedPlatforms { get; set; }

        /// <summary>
        /// The tags associated with the game
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// The last time the game was picked
        /// </summary>
        public DateTime LastPicked { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">The name of the game</param>
        /// <param name="players">The players supported</param>
        /// <param name="platforms">The platforms supported</param>
        /// <param name="tags">The game tags</param>
        public GameModel(string name = null, int players = 1, int platforms = 0, params string[] tags)
        {
            Name = string.IsNullOrEmpty(name) ? "Bad Title" : name;
            SupportedPlayers = Math.Max(players, 1);
            SupportedPlatforms = platforms;
            Tags = String.Join(",", tags);
        }

        /// <summary>
        /// Serialize-friendly constructor
        /// </summary>
        public GameModel() : this("Bad Title", 1, (int)Platform.Xbox)
        {
        }
    }
}
