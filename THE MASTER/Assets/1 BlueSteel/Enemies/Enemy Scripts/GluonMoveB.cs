using UnityEngine;
using System.Collections;

public class GluonMoveB : MonoBehaviour {
	private float tCycle=0;
	public float cycleSpeed;
	private float offset;
	private Move moveScript; 
	void Start () {
		moveScript=GetComponent<Move>();
	}
	void Update () {
		if(tCycle>(Mathf.PI*2)){
			tCycle=0;
		}
		tCycle+=Time.deltaTime;
		offset=Mathf.Sin(tCycle);
		transform.Translate(getNormal(moveScript.getDir())*offset);
	}
	
	private Vector3 getNormal(Vector3 v){
		Vector3 n = new Vector3(v.z, v.y, v.x);
		n.Normalize();
		return n;
	}
}
