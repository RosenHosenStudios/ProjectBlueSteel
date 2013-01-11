using UnityEngine;
using System.Collections;

public class MoveEnhancerCloser : MonoBehaviour {
	private Vector3 pos;
	private Vector3 plps;
	private GameObject Target;
	float dist;
	private Move moveScript;
	private float mult;
	public float maxMult = 0.5f;
	void Start (){
		moveScript=GetComponent<Move>();
		Target = GameObject.FindWithTag("Player");
	}
	void Update () {
		plps= Target.transform.position;
		pos=transform.position;
		dist=(plps-pos).magnitude;
		KillMe();
		//mult=(1/Mathf.Pow(dist,2f));
		mult=(0.5f/dist);
		if (mult<maxMult){
			moveScript.mult = mult;
		}else{
			moveScript.mult = maxMult;
		}
	}
	
	void KillMe(){
		if(dist<0.5f){
			Target.GetComponent<Controller>().Damage(5);
			Destroy(this.gameObject);		
		}
	}
}
