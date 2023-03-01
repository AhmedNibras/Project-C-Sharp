using System;
using System.Collections;
using System.Xml;

namespace SongProject
{
    public class Songs : MarshalByRefObject
    {
        XmlTextReader xmlReader;
        XmlDocument xmlDoc;
        XmlNode xmlNodeRoot;

        public Songs()
        {
            xmlReader = new XmlTextReader("Songs.xml");
            xmlReader.WhitespaceHandling = WhitespaceHandling.None;
            xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlReader);
            xmlNodeRoot = xmlDoc.DocumentElement;
            Console.WriteLine("Song loaded.");
        }

        public ArrayList GetAllSongs()
        {
            XmlNode currentSong = xmlNodeRoot.FirstChild;
            ArrayList names = new ArrayList();

            while (currentSong != null)
            {
                XmlNode tempNode = currentSong.FirstChild.FirstChild;
                names.Add(tempNode.Value);
                currentSong = currentSong.NextSibling;
            }
            return names;
        }

        public string GetSong(string cname)
        {
            XmlNode currentSong = xmlNodeRoot.FirstChild;
            while (currentSong != null)
            {
                XmlNode tempNode = currentSong.FirstChild.FirstChild;
                if (tempNode.Value == cname)
                {
                    tempNode = currentSong.FirstChild.NextSibling.FirstChild;
                    return tempNode.Value;
                }
                currentSong = currentSong.NextSibling;
            }
            return "(Artist not Found)";
        }
    }
}
