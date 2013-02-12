using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	public int hp = 100;
	int movemult = 15;
	public GameObject BOOLET;
	public int bulletSpeed;
	public float fireSpeed;
	private float nextFire;
	public GameObject aimer;
	public Vector3 aim;
	void Start () {
	}

	void Update () {
		Control();
	}
	
	void Control(){
		nextFire += Time.deltaTime;
		if(Input.GetKey("w")){
			transform.Translate(Vector3.forward * movemult * Time.deltaTime);
		}else if (Input.GetKey ("s")){
			transform.Translate(Vector3.back * movemult * Time.deltaTime);
		}
		if(Input.GetKey("a")){
			transform.Translate(Vector3.left * movemult * Time.deltaTime);
		}else if (Input.GetKey ("d")){
			transform.Translate(Vector3.right * movemult * Time.deltaTime);
		}
		if(Input.GetMouseButton (0)){
			fire (aimWith(aimer));
		}
	}
		
	public void Damage(int damage){
		hp=hp-damage;
		if(hp<=0){
			Destroy(transform.Find("Kirby").gameObject);
		}
	}
	
	public void fire(Vector3 dir) {
		try{
			if (nextFire >= fireSpeed){
				GameObject bullet = (GameObject) Instantiate(BOOLET, transform.position, Quaternion.identity);
				bullet.rigidbody.velocity = dir * bulletSpeed;
				nextFire =0;
			}
		} catch (UnityException e) {
		}
	}
	
	private Vector3 aimWith(GameObject aimBot){
		float theta = aimBot.transform.eulerAngles.y * Mathf.Deg2Rad;
		// print ("theta = " + theta);
		aim = new Vector3 (Mathf.Sin(theta),0,Mathf.Cos(theta));
		return aim;
	}
}
