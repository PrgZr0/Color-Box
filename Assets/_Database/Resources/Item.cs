using UnityEngine;
using System.Collections;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

public class Item {

	[XmlAttribute("name")]
	public string name;

	[XmlElement("Damage")]
	public float Damage;

	[XmlElement("Durability")]
	public float Durability;


}
