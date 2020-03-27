using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Xml;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	Mutex mXmlSection = new Mutex();
	Mutex mListSection = new Mutex();
	List<int> mReceiverIds = new List<int>();
	List<int> mSenderIds = new List<int>();
	public static List<string> mSentData = new List<string>();
	bool mNewService = true;
	string mXmlFilePath = @"C:\Users\madma\Documents\GitRepos\CSE_598_Software_Integration\Project_3\Assignment_5\MessagingService\XmlMessageStorage.xml";

	
	public void SendMessage(int senderID, int receiverID, string message)
	{
		// Lock the list section
		mListSection.WaitOne();
		// Check to see if the receiver id has been stored
		if(!mReceiverIds.Contains(receiverID))
		{
			mReceiverIds.Add(receiverID);
		}
		// Check to see if the sender id has been stored
		if (!mSenderIds.Contains(senderID))
		{
			mSenderIds.Add(senderID);
		}
		// Unlock the list section
		mListSection.ReleaseMutex();

		// Write data to xml
		WriteToXml(senderID, receiverID, message);
	}

	public string[] ReceiveMessage(int receiverID, bool purge)
	{
		string[] values = ReadFromXml(receiverID);
		if(purge)
		{
			// lock the document
			mXmlSection.WaitOne();
			// Purge the document
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(mXmlFilePath);
			XmlElement root = xmlDoc.DocumentElement;
			root.RemoveAll();
			xmlDoc.Save(mXmlFilePath);
			// Purge the returned messages list
			mSentData.Clear();
			// unlock the document
			mXmlSection.ReleaseMutex();
		}
		return values;
	}

	private void WriteToXml(int senderID, int receiverID, string message)
	{
		// Check to see if this is the first time this service has started
		if(mNewService)
		{
			// Lock the xml file
			mXmlSection.WaitOne();
			if (!File.Exists(mXmlFilePath))
			{
				// Create the XmlFile
				XmlTextWriter xmlWriter = new XmlTextWriter(mXmlFilePath, null);
				// Format the file
				xmlWriter.Formatting = Formatting.Indented;
				// Place the data
				xmlWriter.WriteStartElement("Messages");
				xmlWriter.WriteStartElement("Message");
				xmlWriter.WriteStartElement("SenderID");
				xmlWriter.WriteString(senderID.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("ReceiverID");
				xmlWriter.WriteString(receiverID.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Data");
				xmlWriter.WriteString(message);
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Time");
				xmlWriter.WriteString(DateTime.Now.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndElement();
				// Close the writer
				xmlWriter.Close();
			}
			else
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load(mXmlFilePath);
				XmlNode root = xmlDoc.DocumentElement;
				XmlNode newMessage = xmlDoc.CreateNode(XmlNodeType.Element, "Message", null);

				XmlNode nodeSenderId = xmlDoc.CreateNode(XmlNodeType.Element, "SenderID", null);
				nodeSenderId.InnerText = senderID.ToString();
				newMessage.AppendChild(nodeSenderId);

				XmlNode nodeReceiverId = xmlDoc.CreateNode(XmlNodeType.Element, "ReceiverID", null);
				nodeReceiverId.InnerText = receiverID.ToString();
				newMessage.AppendChild(nodeReceiverId);

				XmlNode nodeData = xmlDoc.CreateNode(XmlNodeType.Element, "Data", null);
				nodeData.InnerText = message;
				newMessage.AppendChild(nodeData);

				XmlNode nodeTime = xmlDoc.CreateNode(XmlNodeType.Element, "Time", null);
				nodeTime.InnerText = DateTime.Now.ToString();
				newMessage.AppendChild(nodeTime);

				root.AppendChild(newMessage);

				xmlDoc.Save(mXmlFilePath);
			}
			// Unlock the xml file
			mXmlSection.ReleaseMutex();
		}
	}

	private string[] ReadFromXml(int receiverID)
	{
		// Output variables
		List<string> output = new List<string>();
		// Lock the document
		mXmlSection.WaitOne();
		// Open the document
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.Load(mXmlFilePath);

		// Get the message nodes
		XmlElement root = xmlDoc.DocumentElement;
		XmlNodeList nodes = root.SelectNodes("//Messages/Message");

		// Check each message for receiver id
		foreach (XmlNode node in nodes)
		{
			if(node["ReceiverID"].InnerText == receiverID.ToString())
			{
				// Get the information from the node
				string data = node["Time"].InnerText + ":" + node["SenderID"].InnerText + ":" + node["Data"].InnerText;
				// Check to see if the data has already been sent to the user
				if (!mSentData.Contains(data))
				{
					mSentData.Add(data);
					output.Add(data);
				}
			}
		}
		// Unlock the document
		mXmlSection.ReleaseMutex();
		// Return the value
		return output.ToArray();
	}
}
