using UnityEngine;
using System.Collections;

public class ElectronEnhancer : MonoBehaviour {
	private GameObject player;
	private Vector3 pos;
	// Object Position
	private Vector3 plpo;	
	// Player Position
	private Vector3 toGo;
	private float dist;
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	void Update () {
		pos=transform.position;
		plpo=player.transform.position;
		dist=(plpo-pos).magnitude;
		if(dist<1.0f){
			player.GetComponent<Controller>().addScore(1);
			Destroy(this.gameObject);		
		}
	}
}
