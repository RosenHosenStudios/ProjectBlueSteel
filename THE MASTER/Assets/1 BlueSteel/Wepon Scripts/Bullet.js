//Breaks Bullets
var lifeTime = 3;
function Start() {
	yield WaitForSeconds(lifeTime);
	Destroy(this.gameObject);
}
