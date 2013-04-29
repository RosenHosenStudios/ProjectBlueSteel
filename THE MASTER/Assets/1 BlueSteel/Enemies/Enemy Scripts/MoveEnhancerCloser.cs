using UnityEngine;
using System.Collections;

public class MoveEnhancerCloser : MonoBehaviour {
	float dist;
	private Move moveScript;
	private float mult;
	public float maxMult = 0.5f;
	void Start (){
		moveScript=GetComponent<Move>();
	}
	void Update () {
		dist=moveScript.getDist();
		mult=(0.5f/dist);
		if (mult<maxMult){
			moveScript.mult = mult;
		}else{
			moveScript.mult = maxMult;
		}
	}
}
