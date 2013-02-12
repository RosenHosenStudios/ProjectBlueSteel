using UnityEngine;
using System.Collections;
public class BulletCollide : MonoBehaviour {
	public int damageDealt;
	void OnTriggerEnter(Collider collider) {
		if (collider.CompareTag("Enemy")){
			collider.GetComponent<GetHit>().Damage(damageDealt);
			Destroy(this.gameObject);
		}
	}
}