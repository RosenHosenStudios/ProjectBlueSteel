var lifeTime = 0;
function Start() {
	yield WaitForSeconds(lifeTime);
	Destroy(this.gameObject);
}