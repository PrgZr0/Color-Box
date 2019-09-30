using UnityEngine;
using System.Collections;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
[XmlRoot("ItemCollection")]

public  class ItemContainer {
	[XmlArray("Items")]
	[XmlArrayItem("Item")]

	public List<Item> items=new List<Item>();
	public static ItemContainer Load(string path)
	{
		//TextAsset xml = Resources.Load<TextAsset>(path);
		FileStream _xml=new FileStream(path,FileMode.Open);
		XmlSerializer serializer = new XmlSerializer(typeof(ItemContainer));
		StreamReader reader=new StreamReader(_xml);
	
		ItemContainer items = serializer.Deserialize(reader) as ItemContainer;

		reader.Close();
		return items;
	}

}
