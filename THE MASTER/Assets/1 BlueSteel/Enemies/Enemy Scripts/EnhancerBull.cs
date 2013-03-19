using UnityEngine;
using System.Collections;

public class EnhancerBull : MonoBehaviour {
	private Vector3 pos;
	private Vector3 plps;
	private GameObject Target;
	float dist;
	private Move moveScript;
	private float mult;
	public float maxMult;
	private Vector3 offset;
	void Start (){
		moveScript=GetComponent<Move>();
		Target = GameObject.FindWithTag("Player");
		offset = new Vector3(1,0,0);
	}
	void Update () {
		plps= Target.transform.position;
		pos=transform.position;
		dist=(plps-pos).magnitude;
		this.Mupdate();
		transform.Translate((offset));
	}
	
	void Mupdate(){
		//if (dist<20.0f){
			moveScript.mult = maxMult;
		//}else{
		//	moveScript.mult = 0;
		//}
	}
}
