using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {
	public static int spawnArraySize = 7;
	public GameObject[] toSpawn = new GameObject[spawnArraySize];
	public float[] spawnRates = new float[spawnArraySize];
	private float[] spawnTimes = new float[spawnArraySize];
	public int radius;
	private GameObject player;
	void Start() {
		this.gameObject.audio.Play();
		player = GameObject.FindWithTag("Player");
		for(int n=0;n<spawnTimes.Length;n++){
			spawnTimes[n]=0;
		}
	}
	
	// Update is called once per frame
	void Update() {
		playerLock();
		for(int n=0;n<toSpawn.Length;n++){
			spawnEnemy(n);
		}
	}
	
	private void playerLock(){
		Vector3 posRelevant = new Vector3(player.transform.position.x,12,player.transform.position.z);
		if(posRelevant.magnitude>radius){
			Vector3 add = (new Vector3(0,12,0)-player.transform.position).normalized;
			player.transform.Translate(add);
		}
	}
	
	private void spawnEnemy(int n){
		if(toSpawn[n]!=null){
			spawnTimes[n]+=Time.deltaTime;
			if(spawnTimes[n]>spawnRates[n]){
				spawnTimes[n]=0.0f;
				Vector2 temp = Random.insideUnitCircle*60;
				Vector3 locToSpawn = new Vector3(temp.x,12,temp.y);
				Instantiate(toSpawn[n],locToSpawn,Quaternion.identity);
			}
		}
	}
	
}
