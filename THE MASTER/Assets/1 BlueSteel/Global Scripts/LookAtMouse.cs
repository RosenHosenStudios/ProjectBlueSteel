using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour {
	private Vector3 aim;
	public GameObject aimFor;
	
	void Update () {
		aim = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		aim.y = aimFor.transform.eulerAngles.y;
		transform.LookAt(aim);
	}
}
