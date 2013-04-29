using UnityEngine;
using System.Collections;

public class SpedAnimate : MonoBehaviour {

	void Start () {
		foreach (AnimationState state in animation) {            
			state.speed = 3.0F;
		}
	}
}
	
