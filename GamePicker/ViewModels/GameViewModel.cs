namespace HoboNightGamePickerWeb.ViewModels
{
    public class GameViewModel : IComparable
    {
        private GameModel model;

        public Guid Id { get => model.Id; set => model.Id = value; }

        /// <summary>
        /// Game title. Sequels are different titles.
        /// </summary>
        public string Name { get => model.Name; set => model.Name = value; }

        /// <summary>
        /// The number of players the game supports (6 is treated as 6+)
        /// </summary>
        public int SupportedPlayers { get => model.SupportedPlayers; set => model.SupportedPlayers = value; }

        /// <summary>
        /// Bit field containing supported platform information
        /// </summary>
        public int SupportedPlatforms { get => model.SupportedPlatforms; set => model.SupportedPlatforms = value; }

        /// <summary>
        /// The tags associated with the game
        /// </summary>
        public string Tags { get => model.Tags; set => model.Tags = value; }

        /// <summary>
        /// The last time the game was picked
        /// </summary>
        public DateTime LastPicked { get; set; }

        public GameViewModel(GameModel model)
        {
            this.model = model;
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
        public bool ContainsTag(string tag) => Tags.Contains(tag, StringComparison.OrdinalIgnoreCase);

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
            foreach (string tag in newTags)
            {
                if (!Tags.Contains(tag))
                {
                    Tags = String.Join(",", Tags, tag);
                }
            }
        }

        public static bool operator ==(GameViewModel game, string name)
        {
            return string.Equals(game?.Name, name, StringComparison.OrdinalIgnoreCase);
        }

        public static bool operator !=(GameViewModel game, string name)
        {
            return !string.Equals(game?.Name, name, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            return string.Equals(this.Name, ((GameViewModel)obj)?.Name, StringComparison.OrdinalIgnoreCase);
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
            return this.Name.CompareTo(((GameViewModel)obj).Name);
        }
    }
}
