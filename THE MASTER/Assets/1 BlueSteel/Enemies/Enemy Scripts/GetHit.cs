using UnityEngine;
using System.Collections;

public class GetHit : MonoBehaviour {

	public int HP;
	void Update(){
		if(HP<=0){
			Destroy(this.gameObject);
		}
	}
	public void Damage(int dmg){
		HP-=dmg;
	}
}
