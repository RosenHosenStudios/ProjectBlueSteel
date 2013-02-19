using UnityEngine;
using System.Collections;

public class EnhancerBull : MonoBehaviour {
	private Vector3 pos;
	private Vector3 plps;
	private GameObject Target;
	float dist;
	private Move moveScript;
	private float mult;
	public float maxMult = 4.0f;
	void Start (){
		moveScript=GetComponent<Move>();
		Target = GameObject.FindWithTag("Player");
	}
	void Update () {
		plps= Target.transform.position;
		pos=transform.position;
		dist=(plps-pos).magnitude;
		this.Mupdate();
	}
	
	void Mupdate(){
		if(dist<0.5f){
			Target.GetComponent<Controller>().Damage(20);
			Destroy(this.gameObject);		
		}else if (dist<10.0f){
			moveScript.mult = maxMult;
		}else{
			moveScript.mult = 0;
		}
	}
}
