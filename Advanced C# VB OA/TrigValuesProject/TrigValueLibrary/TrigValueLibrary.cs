using System;
using System.Collections;
using System.Xml;

namespace TrigValueLibrary
{
    public class TrigValue : MarshalByRefObject
    {
        XmlTextReader xmlReader;
        XmlDocument xmlDoc;
        XmlNode xmlNodeRoot;

        public TrigValue()
        {
            xmlReader = new XmlTextReader("Trigvalues.xml");
            xmlReader.WhitespaceHandling = WhitespaceHandling.None;
            xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlReader);
            xmlNodeRoot = xmlDoc.DocumentElement;
            Console.WriteLine("Trigvalues loaded ");
        }

        public ArrayList GetAllValues(int degree)
        {
            XmlNode currentContact = xmlNodeRoot.FirstChild;
            ArrayList values = new ArrayList();

            while (currentContact != null)
            {
                XmlNode tempNode = currentContact.FirstChild.FirstChild;
                if (int.Parse(tempNode.Value) == degree)
                {
                    tempNode = currentContact.FirstChild.FirstChild;
                    if (int.Parse(tempNode.Value) == degree)
                    {
                        tempNode = currentContact.FirstChild.NextSibling.FirstChild;
                        values.Add(tempNode.Value);
                        tempNode = currentContact.FirstChild.NextSibling.NextSibling.FirstChild;
                        values.Add(tempNode.Value);
                        tempNode = currentContact.FirstChild.NextSibling.NextSibling.NextSibling.FirstChild;
                        values.Add(tempNode.Value);
                        return values;
                    }
                }
                currentContact = currentContact.NextSibling;
            }
            return null;
        }

        public string GetValue(int degree, string function)
        {
            XmlNode currentContact = xmlNodeRoot.FirstChild;
            while (currentContact != null)
            {
                XmlNode tempNode = currentContact.FirstChild.FirstChild;
                if (int.Parse(tempNode.Value) == degree)
                {
                    switch (function)
                    {
                        case "sin":
                            return currentContact.FirstChild.NextSibling.FirstChild.Value;

                        case "cos":
                            return currentContact.FirstChild.NextSibling.FirstChild.Value;

                        case "tan":
                            return currentContact.FirstChild.NextSibling.FirstChild.Value;

                        default:
                            return "No such function";

                    }
                }
                currentContact = currentContact.NextSibling;
            }
            return "(Angle no: found)";
        }

    }
}
