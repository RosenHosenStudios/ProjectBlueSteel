using UnityEngine;
using System.Collections;

public class EnhancerSpawner : MonoBehaviour {
	public GameObject toSpawn;
	private double spawnInterval;
	double clock;
	void Start () {
		clock=0;
		spawnInterval=0.2;
	}
	
	void Update () {
		clock+=Time.deltaTime;
		if (clock>=spawnInterval){
			clock=0;
			newChaser();
		}
	}
	
	void newChaser(){
	 GameObject Chaser = Instantiate(toSpawn,transform.position,Quaternion.identity) as GameObject;
	}
}
