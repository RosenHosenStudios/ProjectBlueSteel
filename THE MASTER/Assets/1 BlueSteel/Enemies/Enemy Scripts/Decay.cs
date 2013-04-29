using UnityEngine;
using System.Collections;

public class Decay : MonoBehaviour {

	private float time;
	public float maxTime;
	void Update () {
		time += Time.deltaTime;
		if(time>maxTime){Destroy(this.gameObject);}
	}
}
