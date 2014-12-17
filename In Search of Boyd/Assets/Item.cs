using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public GameObject myInventory;
	public Inventory inventoryScript;
	public Texture inventoryObject; //adjust to gameObject

	
	//public bool isActive;
	
	// Use this for initialization
	void Start () 
	{
		inventoryScript = myInventory.GetComponent<Inventory> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		inventoryScript.itemArray [inventoryScript.counter] = this.gameObject;
		Debug.Log("You picked up: " + inventoryScript.itemArray [inventoryScript.counter].name);
		inventoryScript.counter ++;
		
		
		this.gameObject.SetActive (false);
		inventoryObject = gameObject.guiTexture.texture;
		
		//Debug.Log ("THIS ITEM IS COLLECTED");
		//isActive = false;
		
	}
}
