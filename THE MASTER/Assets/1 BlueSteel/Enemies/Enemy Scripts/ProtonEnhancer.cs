using UnityEngine;
using System.Collections;

public class ProtonEnhancer : MonoBehaviour {
	private Vector3 direction;
	private float releaseSpeed = 5.0f;
	private float clock = 0.0f;
	public GameObject toRelease;
	
	void Start () {
		direction = this.generateDirection();
	}
	
	void Update () {
		transform.Translate(direction);
		releaseGluons();
	}
	
	private Vector3 generateDirection(){
		GameObject player = GameObject.FindWithTag("Player");
		return ((player.transform.position-this.transform.position).normalized)/4;
	}
	
	void releaseGluons(){
		clock+=Time.deltaTime;
		if(clock>releaseSpeed){
			Instantiate(toRelease,this.transform.position,Quaternion.identity);
			clock=0;
		}
	}
}
