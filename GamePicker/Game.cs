using System;
using System.Collections.Generic;
using System.Linq;

namespace GamePicker
{
    public enum Platform
    {
        Xbox = 0x1,
        PlayStation = 0x2,
        Switch = 0x4,
        PC = 0x8,
        Mobile = 0x10
    }

    public class Game : IComparable
    {
        public string Name { get; set; }

        public int SupportedPlayers { get; set; }

        public int SupportedPlatforms { get; set; }

        public List<string> Tags { get; private set; }

        public Game(string name = null, int players = 1, int platforms = (int)Platform.Xbox, params string[] tags)
        {
            Name = string.IsNullOrEmpty(name) ? "Bad Title" : name;
            SupportedPlayers = Math.Max(players, 1);
            SupportedPlatforms = platforms;
            Tags = new List<string>(tags);
        }

        public Game() : this("Bad Title", 1, (int)Platform.Xbox)
        {
        }

        public bool SupportsPlatform(Platform platform) => (SupportedPlatforms & (int)platform) != 0;

        public bool SupportsPlatforms(int platforms) => (SupportedPlatforms & platforms) == platforms;

        public bool ContainsTag(string tag) => Tags.Contains(tag, StringComparer.OrdinalIgnoreCase);

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

        public void AddTags(string[] newTags)
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
