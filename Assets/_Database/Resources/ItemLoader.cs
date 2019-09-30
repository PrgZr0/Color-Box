using UnityEngine;
using System.Collections;

public class ItemLoader : MonoBehaviour {

	public const string path=@"D:\Color Box\Assets\Resources\Items.xml";

	void Start () {
		ItemContainer i= ItemContainer.Load(path);
		foreach(Item item in i.items)
		{
			Debug.Log(item.name);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
