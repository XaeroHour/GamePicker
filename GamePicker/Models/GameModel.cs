using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GamePicker.Models;

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
public class GameModel : IComparable
{
    /// <summary>
    /// Title Id
    /// </summary>
    public int Id { get; set; } = 0;

    /// <summary>
    /// Game title. Sequels are different titles.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// The number of players the game supports (6 is treated as 6+)
    /// </summary>
    [Display(Name = "Supported Players")]
    public int SupportedPlayers { get; set; } = 1;

    /// <summary>
    /// Bit field containing supported platform information
    /// </summary>
    [Display(Name = "Supported Platforms")]
    public int SupportedPlatforms { get; set; } = 0;

    /// <summary>
    /// The tags associated with the game
    /// </summary>
    public string Tags { get; set; } = string.Empty;

    /// <summary>
    /// The last time the game was picked
    /// </summary>
    [Display(Name = "Last Picked")]
    [DataType(DataType.Date)]
    public DateTime LastPicked { get; set; } = DateTime.MinValue;

    /// <summary>
    /// The last time the game was played (separate from picked to support manual calls)
    /// </summary>
    [Display(Name = "Last Played")]
    [DataType(DataType.Date)]
    public DateTime LastPlayed { get; set; } = DateTime.MinValue;

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="name">The name of the game</param>
    /// <param name="players">The players supported</param>
    /// <param name="platforms">The platforms supported</param>
    /// <param name="tags">The game tags</param>
    public GameModel(string name = null, int players = 1, int platforms = 0, params string[] tags)
    {
        Title = string.IsNullOrEmpty(name) ? "Bad Title" : name;
        SupportedPlayers = Math.Max(players, 1);
        SupportedPlatforms = platforms;
        Tags = string.Join(",", tags.Select(t => t.ToLower()));
    }

    /// <summary>
    /// Serialize-friendly constructor
    /// </summary>
    public GameModel() : this("Bad Title", 1, (int)Platform.Xbox)
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
    public bool ContainsTag(string tag) => Tags.Contains(tag.ToLower());

    /// <summary>
    /// Specifies if the given tags are associated to the game
    /// </summary>
    /// <param name="tags">The tags to search for</param>
    /// <returns>Returns true if all the tags are in the game, false otherwise</returns>
    public bool ContainsTags(IEnumerable<string> tags)
    {
        if (Tags == null)
        {
            return false;
        }

        if (tags != null)
        {
            foreach (string tag in tags)
            {
                if (!Tags.Contains(tag.ToLower()))
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
            if (!Tags.Contains(tag.ToLower()))
            {
                Tags = $"{Tags};{tag.ToLower()}";
            }
        }
        Tags = Tags.Trim("; ".ToCharArray());
    }

    public static bool operator ==(GameModel game, string name)
    {
        return string.Equals(game?.Title, name, StringComparison.OrdinalIgnoreCase);
    }
    public static bool operator !=(GameModel game, string name)
    {
        return !string.Equals(game?.Title, name, StringComparison.OrdinalIgnoreCase);
    }

    public override bool Equals(object obj)
    {
        return string.Equals(Title, ((GameModel)obj)?.Title, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return Title;
    }

    public int CompareTo(object obj)
    {
        return Title.CompareTo(((GameModel)obj).Title);
    }
}
