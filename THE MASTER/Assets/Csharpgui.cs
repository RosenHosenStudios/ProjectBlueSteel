using UnityEngine;
using System.Collections;

public class Csharpgui : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnGUI () {
		// Makes a background box
		GUI.Box(new Rect(10,10,200,90), "Hit Points "+GameObject.Find("Player").GetComponent<Controller>().hp);
		Debug.Log (GameObject.Find("Player").GetComponent<Controller>().hp ); 
	}
	// Update is called once per frame
	void Update () {
	
	}
}
