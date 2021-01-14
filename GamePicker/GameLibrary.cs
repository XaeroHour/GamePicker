using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace GamePicker
{
    public class GameLibrary
    {
        public List<Game> Library = new List<Game>();

        public string XMLFilePath { get; private set; }

        public GameLibrary()
        {
            XMLFilePath = "HoboGameLibrary.xml";
            Deserialize();
        }

        ~GameLibrary()
        {
            Serialize();
        }

        public void AddGame(Game newTitle)
        {
            if(!Library.Contains(newTitle))
            {
                Library.Add(newTitle);
            }
        }

        public void Serialize()
        {
            XmlSerializer serializer = new XmlSerializer(Library.GetType());

            Library.Sort();

            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {
                serializer.Serialize(writer, Library);
            }
        }

        public void Deserialize()
        {
            if(!File.Exists(XMLFilePath))
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(Library.GetType());

            using (StreamReader reader = new StreamReader(XMLFilePath))
            {
                Library = (List<Game>)serializer.Deserialize(reader);
                Library.Sort();
            }
        }
    }
}
