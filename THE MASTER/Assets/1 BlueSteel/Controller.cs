using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	public int hp = 100;
	int movemult = 15;
	public GameObject BOOLET;
	public int bulletSpeed;
	void Start () {
	}

	void Update () {
		Control();
	}
	
	void Control(){
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
		if(Input.GetKey ("up")){
			fire ();
		}
	}
		
	public void Damage(int damage){
		hp=hp-damage;
		if(hp<=0){
			Destroy(transform.Find("Kirby").gameObject);
		}
	}
	
	public void fire() {
	GameObject bullet = (GameObject) Instantiate(BOOLET, transform.position, Quaternion.identity);
	bullet.rigidbody.velocity = transform.forward * bulletSpeed;
}
}
