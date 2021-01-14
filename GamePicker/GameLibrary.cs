using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
        public static List<Game> HoboGameLibrary = new List<Game>();

        /// <summary>
        /// 
        /// </summary>
        public static string XMLFilePath { get; } = @"Files\HoboGameLibrary.xml";

        static GameLibrary()
        {
            Deserialize();
        }

        public static void SaveLibrary()
        {
            Serialize();
        }

        public static void AddGame(Game newTitle)
        {
            if(!HoboGameLibrary.Contains(newTitle))
            {
                HoboGameLibrary.Add(newTitle);
            }
        }

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
                HoboGameLibrary = (List<Game>)serializer.Deserialize(reader);
                HoboGameLibrary.Sort();
            }
        }
    }
}
