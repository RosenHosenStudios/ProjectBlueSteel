using UnityEngine;
using System.Collections;

public class SpawnChasers : MonoBehaviour {
	private double clock;
	public GameObject chaserPref;
	
	// Update is called once per frame
	void Update () {
		clock+=Time.deltaTime;
		if (clock>=2){
			newChaser();
			clock=0;
		}
	}
	
	void newChaser(){
	 GameObject Chaser = Instantiate(chaserPref, new Vector3(0,0,0),Quaternion.identity) as GameObject;
	}
}
