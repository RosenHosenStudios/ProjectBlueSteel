using UnityEngine;
using System.Collections;

public class EnhancerSpawner : MonoBehaviour {
	public GameObject toSpawn;
	double clock;
	void Start () {
		clock=0;
	}
	
	void Update () {
		clock+=Time.deltaTime;
		if (clock>=5){
			clock=0;
			newChaser();
		}
	}
	
	void newChaser(){
	 GameObject Chaser = Instantiate(toSpawn,transform.position,Quaternion.identity) as GameObject;
	}
}
