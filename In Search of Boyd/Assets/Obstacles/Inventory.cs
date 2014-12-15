using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour 
{
	//adjust inventoryObject variable in ItemScript

	private Item itemScript1;
	private Item itemScript2;
	private Item itemScript3;
	private Item itemScript4;
	private Item itemScript5;
	//private bool inventoryToggle = true; 
	private Rect inventoryWindowRect = new Rect(0,420, 810, 100);
	//new GameObject[] inventoryArray = new GameObject[10];
	//int arrayNumber = 0;
	// Use this for initialization

	void Start () 
	{
		//itemScript1 = GameObject.Find ("Key").GetComponent<Item>();
		itemScript2 = GameObject.Find ("ID CARD").GetComponent<Item>();
		//itemScript3 = GameObject.Find ("Book").GetComponent<Item>();
		//itemScript4 = GameObject.Find ("Paper").GetComponent<Item>();
		//itemScript5 = GameObject.Find ("Money").GetComponent<Item>();
		//inventoryArray [1] = null;
	}
	
	// Update is called once per frame
	void Update () 
	{
		OnGUI();
	}

	void OnGUI()
	{

			inventoryWindowRect = GUI.Window (0, inventoryWindowRect, inventoryWindowMethod, "Inventory");
		
	}

	void inventoryWindowMethod (int windowID)
	{
			
		GUILayout.BeginArea(new Rect(50,30,750,100));
		GUILayout.BeginHorizontal ();
		GUILayout.Box ("", GUILayout.Height (50), GUILayout.Width (100));
		GUILayout.Box ("", GUILayout.Height (50), GUILayout.Width (100));
		GUILayout.Box (itemScript2.inventoryObject, GUILayout.Height (50), GUILayout.Width(100));
		GUILayout.Box ("", GUILayout.Height (50), GUILayout.Width (100));
		GUILayout.Box ("", GUILayout.Height (50), GUILayout.Width (100));
		GUILayout.Box ("", GUILayout.Height (50), GUILayout.Width (100));
		GUILayout.Box ("", GUILayout.Height (50), GUILayout.Width (100));
		GUILayout.EndHorizontal ();
		GUILayout.EndArea ();



			/*Debug.Log("Iterating");
			if(itemScript.itemArray[i].activeInHierarchy == false);
			{
				 //this.gameobject.SpriteRenderer.Sprite;

			}*/

		
	}


	/*void ItemActive()
	{
		foreach (GameObject item in itemScript.itemArray) 
		{
			
			if(item.activeInHierarchy == false)
			{
				inventoryArray[arrayNumber] = item;
				arrayNumber++;
			}
		}

	}*/
	//display itemScript.itemArray[i].

}