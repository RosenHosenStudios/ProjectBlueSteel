using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {	
	private Vector3 pos;
	// Object Position
	private Vector3 plpo;	
	// Player Position
	private Vector3 toGo;
	private Vector3 prev;
	public float mult;
	private GameObject player;
	public Vector3 dir; //Designed to be read by other scripts, not edited.
	void Start(){
		player = GameObject.FindWithTag("Player");
	}
	void Update () {
		pos=transform.position;
		plpo=player.transform.position;
		toGo=plpo-pos;
		toGo=toGo/toGo.magnitude;
		dir=mult*(toGo+prev);
		transform.Translate(dir);
		prev=toGo;
		
	}
}
