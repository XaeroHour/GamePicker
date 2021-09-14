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

            try
            {
                using (StreamWriter writer = new StreamWriter(XMLFilePath))
                {
                    serializer.Serialize(writer, HoboGameLibrary);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace, MessageBoxButtons.OK);
            }
        }

        public static void Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(HoboGameLibrary.GetType());

            try
            {
                using (StreamReader reader = File.Exists(XMLFilePath) ?
                    new StreamReader(XMLFilePath) :
                    new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("GamePicker.Files.HoboGameLibrary.xml")))
                {
                    HoboGameLibrary = (List<HoboNightGame>)serializer.Deserialize(reader);
                    HoboGameLibrary.Sort();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Exception hit: {ex.Message}", "Cannot Deserialize", MessageBoxButtons.OK);
            }
        }
    }
}
