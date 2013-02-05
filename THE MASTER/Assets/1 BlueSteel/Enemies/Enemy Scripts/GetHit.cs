using UnityEngine;
using System.Collections;

public class GetHit : MonoBehaviour {

	public int maxHP;
	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag=="FriendlyBullet"){ 
			print("hit");
	 	}
	}
}
