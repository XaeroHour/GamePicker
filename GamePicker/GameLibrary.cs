using GamePicker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace GamePicker;

/// <summary>
/// Class for managing a game library
/// </summary>
public static class GameLibrary
{
    /// <summary>
    /// The list of games in the library
    /// </summary>
    private static readonly List<GameModel> _hoboGameLibrary = new();

    /// <summary>
    /// Provides a read-only view of the game library
    /// </summary>
    public static ReadOnlyCollection<GameModel> HoboGameLibrary => _hoboGameLibrary.AsReadOnly();

    /// <summary>
    /// Add a game to the library if it isn't already present
    /// </summary>
    /// <param name="newTitle">The new game to add</param>
    public static void AddGame(GameModel newTitle)
    {
        if (!_hoboGameLibrary.Contains(newTitle))
        {
            _hoboGameLibrary.Add(newTitle);
        }
    }

    /// <summary>
    /// Locate a game in the library
    /// </summary>
    /// <param name="gameName">The name of the game to look up</param>
    /// <returns>Returns the desired game. Null if no game is found.</returns>
    public static GameModel FindGame(string gameName) => _hoboGameLibrary.Find(game => string.Equals(gameName, game.Title, StringComparison.OrdinalIgnoreCase));

    public static void SaveLibraryToXML(string xmlFilePath)
    {
        if (!File.Exists(xmlFilePath))
        {
            return;
        }

        XmlSerializer serializer = new(_hoboGameLibrary.GetType());

        _hoboGameLibrary.Sort();
        using StreamWriter writer = new(xmlFilePath);
        serializer.Serialize(writer, _hoboGameLibrary);
    }

    public static void LoadLibraryFromXML(string xmlFilePath)
    {
        if (!File.Exists(xmlFilePath))
        {
            return;
        }

        XmlSerializer serializer = new(_hoboGameLibrary.GetType());

        using StreamReader reader = new(xmlFilePath);
        _hoboGameLibrary.Clear();
        _hoboGameLibrary.AddRange((List<GameModel>)serializer.Deserialize(reader));
        _hoboGameLibrary.Sort();
    }

    public static void SaveLibraryToSQL()
    {
    }

    public static void LoadLibraryFromSQL()
    {
    }
}
