using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace GamePicker
{
    public static class TagManager
    {
        private static List<string> supportedTags = new List<string>();

        public static List<string> SupportedTags { get => supportedTags; }

        public static string XMLFilePath { get; } = "SupportedTags.xml";

        static TagManager()
        {
            DeserializeTags();
        }

        public static void SaveTags()
        {
            SerializeTags();
        }

        public static bool AddTags(params string[] tags)
        {
            bool tagAdded = false;

            foreach(string tag in tags)
            {
                if(!supportedTags.Contains(tag, StringComparer.OrdinalIgnoreCase))
                {
                    supportedTags.Add(tag);
                    supportedTags.Sort();
                    tagAdded = true;
                }
            }

            return tagAdded;
        }

        public static void RemoveTags(params string[] tags)
        {
            foreach(string tag in tags)
            {
                supportedTags.Remove(tag.ToLower());
            }
        }

        private static void SerializeTags()
        {
            XmlSerializer serializer = new XmlSerializer(supportedTags.GetType());

            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {
                supportedTags.Sort();
                serializer.Serialize(writer, supportedTags);
            }
        }

        private static void DeserializeTags()
        {
            if (!File.Exists(XMLFilePath))
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(supportedTags.GetType());

            using (StreamReader reader = new StreamReader(XMLFilePath))
            {
                supportedTags = (List<string>)serializer.Deserialize(reader);
                supportedTags.Sort();
            }
        }
    }
}
