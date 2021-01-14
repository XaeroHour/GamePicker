using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace GamePicker
{
    /// <summary>
    /// Manage the tags so prevent duplicates and case mismatches
    /// </summary>
    public static class TagManager
    {
        /// <summary>
        /// The recognized tags
        /// </summary>
        private static List<string> supportedTags = new List<string>();

        /// <summary>
        /// Public facing list of recognized tags
        /// </summary>
        public static List<string> SupportedTags { get => supportedTags; }

        /// <summary>
        /// XML location for the tags xml
        /// </summary>
        public static string XMLFilePath { get; } = @"Files\SupportedTags.xml";

        static TagManager()
        {
            DeserializeTags();
        }

        /// <summary>
        /// Save any changes made to the tags to the xml file
        /// </summary>
        public static void SaveTags()
        {
            SerializeTags();
        }

        /// <summary>
        /// Add a series of tags to the list if not already present
        /// </summary>
        /// <param name="tags">Tags to add</param>
        /// <returns>Returns true if at least one of the given tags was added</returns>
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

        /// <summary>
        /// Remove a series of tags from the list
        /// </summary>
        /// <param name="tags">Tags to remove</param>
        public static void RemoveTags(params string[] tags)
        {
            foreach(string tag in tags)
            {
                supportedTags.Remove(tag.ToLower());
            }
        }

        /// <summary>
        /// Serialize the tag list to xml
        /// </summary>
        private static void SerializeTags()
        {
            XmlSerializer serializer = new XmlSerializer(supportedTags.GetType());

            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {
                supportedTags.Sort();
                serializer.Serialize(writer, supportedTags);
            }
        }

        /// <summary>
        /// Deserialize the tag list from the xml
        /// </summary>
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
