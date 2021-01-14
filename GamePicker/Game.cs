using System;
using System.Collections.Generic;
using System.Linq;

namespace GamePicker
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
    public class Game : IComparable
    {
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
        public List<string> Tags { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">The name of the game</param>
        /// <param name="players">The players supported</param>
        /// <param name="platforms">The platforms supported</param>
        /// <param name="tags">The game tags</param>
        public Game(string name = null, int players = 1, int platforms = 0, params string[] tags)
        {
            Name = string.IsNullOrEmpty(name) ? "Bad Title" : name;
            SupportedPlayers = Math.Max(players, 1);
            SupportedPlatforms = platforms;
            Tags = new List<string>(tags);
        }

        /// <summary>
        /// Serialize-friendly constructor
        /// </summary>
        public Game() : this("Bad Title", 1, (int)Platform.Xbox)
        {
        }

        /// <summary>
        /// Specifies if a given platform is supported by the game
        /// </summary>
        /// <param name="platform">The platform to check for</param>
        /// <returns>Returns true if the given platform is supported</returns>
        public bool SupportsPlatform(Platform platform) => (SupportedPlatforms & (int)platform) != 0;

        /// <summary>
        /// Specifies if a given platform configureation is valid for the game
        /// </summary>
        /// <param name="platforms">Bit field set int coresponding to the desired platforms</param>
        /// <returns>Returns true if the given platforms are all supported</returns>
        public bool SupportsPlatforms(int platforms) => (SupportedPlatforms & platforms) == platforms;

        /// <summary>
        /// Specifies if a given tag is associated to the game
        /// </summary>
        /// <param name="tag">The tag to search for</param>
        /// <returns>Returns true if the game has the given tag</returns>
        public bool ContainsTag(string tag) => Tags.Contains(tag, StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Specifies if the given tags are associated to the game
        /// </summary>
        /// <param name="tags">The tags to search for</param>
        /// <returns>Returns true if all the tags are in the game, false otherwise</returns>
        public bool ContainsTags(IEnumerable<string> tags)
        {
            if (tags != null)
            {
                foreach (string tag in tags)
                {
                    if (!this.Tags.Contains(tag))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Convert the given string of parameters to the bitfield
        /// </summary>
        /// <param name="platforms">The names of the supported platforms (names must match enum spelling)</param>
        /// <returns>Returns a bit field set int coresponding to the given platforms</returns>
        public static int ConvertStringsToPlatform(params string[] platforms)
        {
            int platformConfig = 0;

            foreach (string platformName in platforms)
            {
                if (Enum.TryParse(platformName, out Platform result))
                {
                    platformConfig |= (int)result;
                }
            }

            return platformConfig;
        }

        /// <summary>
        /// Adds given tags to the game
        /// </summary>
        /// <param name="newTags">The tags to add</param>
        public void AddTags(params string[] newTags)
        {
            foreach(string tag in newTags)
            {
                if(!Tags.Contains(tag))
                {
                    Tags.Add(tag);
                }
            }
        }

        public override bool Equals(object obj)
        {
            return string.Equals(this.Name, ((Game)obj).Name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            return this.Name.CompareTo(((Game)obj).Name);
        }
    }
}
