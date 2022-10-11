using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
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
        public static List<GameModel> HoboGameLibrary = new List<GameModel>();

        /// <summary>
        /// Add a game to the library if it isn't already present
        /// </summary>
        /// <param name="newTitle">The new game to add</param>
        public static void AddGame(GameModel newTitle)
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
        public static GameModel FindGame(string gameName) => HoboGameLibrary.Find(game => string.Equals(gameName, game.Title, StringComparison.OrdinalIgnoreCase));

        public static void SaveLibraryToXML(string xmlFilePath)
        {
            if (!File.Exists(xmlFilePath))
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(HoboGameLibrary.GetType());

            try
            {
                HoboGameLibrary.Sort();
                using (StreamWriter writer = new StreamWriter(xmlFilePath))
                {
                    serializer.Serialize(writer, HoboGameLibrary);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace, MessageBoxButtons.OK);
            }
        }

        public static void LoadLibraryFromXML(string xmlFilePath)
        {
            if (!File.Exists(xmlFilePath))
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(HoboGameLibrary.GetType());

            try
            {
                using (StreamReader reader = new StreamReader(xmlFilePath))
                {
                    HoboGameLibrary = (List<GameModel>)serializer.Deserialize(reader);
                    HoboGameLibrary.Sort();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Exception hit: {ex.Message}", "Cannot Deserialize", MessageBoxButtons.OK);
            }
        }

        public static void SaveLibraryToSQL()
        {
        }

        public static void LoadLibraryFromSQL()
        {
        }
    }
}
