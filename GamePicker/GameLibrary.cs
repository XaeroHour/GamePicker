using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace GamePicker
{
    /// <summary>
    /// Class for managing a game library
    /// </summary>
    public static class GameLibrary
    {
        /// <summary>
        /// The list of games in the library
        /// </summary>
        public static List<HoboNightGame> HoboGameLibrary = new List<HoboNightGame>();

        /// <summary>
        /// The path to the game library XML
        /// </summary>
        public static string XMLFilePath { get; } = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\GamePicker\HoboGameLibrary.xml";

        static GameLibrary()
        {
            Deserialize();
        }

        /// <summary>
        /// Save the library data out to the XML
        /// </summary>
        public static void SaveLibrary()
        {
            Serialize();
        }

        /// <summary>
        /// Add a game to the library if it isn't already present
        /// </summary>
        /// <param name="newTitle">The new game to add</param>
        public static void AddGame(HoboNightGame newTitle)
        {
            if(!HoboGameLibrary.Contains(newTitle))
            {
                HoboGameLibrary.Add(newTitle);
            }
        }

        /// <summary>
        /// Locate a gmae in the library
        /// </summary>
        /// <param name="gameName">The name of the game to look up</param>
        /// <returns>Returns the desired game. Null if no game is found.</returns>
        public static HoboNightGame FindGame(string gameName) => HoboGameLibrary.Find(game => string.Equals(gameName, game.Name, StringComparison.OrdinalIgnoreCase));

        public static void Serialize()
        {
            XmlSerializer serializer = new XmlSerializer(HoboGameLibrary.GetType());

            HoboGameLibrary.Sort();

            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {
                serializer.Serialize(writer, HoboGameLibrary);
            }
        }

        public static void Deserialize()
        {
            if(!File.Exists(XMLFilePath))
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(HoboGameLibrary.GetType());

            using (StreamReader reader = new StreamReader(XMLFilePath))
            {
                HoboGameLibrary = (List<HoboNightGame>)serializer.Deserialize(reader);
                HoboGameLibrary.Sort();
            }
        }
    }
}
