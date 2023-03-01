using System;
using System.Collections;
using System.Xml;

namespace ContactLibrary
{
    public class Contact : MarshalByRefObject
    {
        XmlTextReader xmlReader;
        XmlDocument xmlDoc;
        XmlNode xmlNodeRoot;

        public Contact()
        {
            xmlReader = new XmlTextReader("Contact.xml");
            xmlReader.WhitespaceHandling = WhitespaceHandling.None;
            xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlReader);
            xmlNodeRoot = xmlDoc.DocumentElement;
            Console.WriteLine("Contact loaded.");
        }

        public ArrayList GetAllContacts()
        {
            XmlNode currentContact = xmlNodeRoot.FirstChild;
            ArrayList names = new ArrayList();

            while (currentContact != null)
            {
                XmlNode tempNode = currentContact.FirstChild.FirstChild;
                names.Add(tempNode.Value);
                currentContact = currentContact.NextSibling;
            }
            return names;
        }

        public string GetContact(string cname)
        {
            XmlNode currentContact = xmlNodeRoot.FirstChild;
            while (currentContact != null)
            {
                XmlNode tempNode = currentContact.FirstChild.FirstChild;
                if (tempNode.Value == cname)
                {
                    tempNode = currentContact.FirstChild.NextSibling.FirstChild;
                    return tempNode.Value;
                }
                currentContact = currentContact.NextSibling;
            }
            return "(Name not Found)";
        }
    }
}
