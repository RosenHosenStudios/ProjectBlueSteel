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
	void Start(){
		player = GameObject.FindWithTag("Player");
	}
	void Update () {
		pos=transform.position;
		plpo=player.transform.position;
		toGo=plpo-pos;
		toGo=toGo/toGo.magnitude;
		transform.Translate(mult*(toGo+prev));
		prev=toGo;
	}
}
