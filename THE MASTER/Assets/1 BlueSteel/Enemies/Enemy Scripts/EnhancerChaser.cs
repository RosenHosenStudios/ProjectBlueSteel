using UnityEngine;
using System.Collections;

public class EnhancerChaser : MonoBehaviour {
	private Vector3 pos;
	private Vector3 plps;
	private GameObject Target;
	public int damage;
	float dist;
	void Start (){
		Target = GameObject.FindWithTag("Player");
	}
	void Update () {
		plps= Target.transform.position;
		pos=transform.position;
		dist=(plps-pos).magnitude;
		KillMe();
	}
	
	void KillMe(){
		if(dist<0.5f){
			Target.GetComponent<Controller>().Damage(damage);
			Destroy(this.gameObject);		
		}
	}
}
