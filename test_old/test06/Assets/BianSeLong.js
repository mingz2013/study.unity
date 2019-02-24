#pragma strict

var p:Vector3;

function Start () {
//	gameObject.renderer.material.color = Color.red;
}

function Update () {
	if(Input.GetKey(KeyCode.W)){
		gameObject.transform.Translate(1 * Time.deltaTime, 0, 0, Space.Self);
	}
	if(Input.GetKey(KeyCode.S)){
		gameObject.transform.Translate(-1 * Time.deltaTime, 0, 0, Space.Self);
	}
	
	p = gameObject.transform.position;
	if(p.x > 4){
		gameObject.renderer.material.color = Color.green;
	}else if(p.x < 4 && p.x > 2){
		gameObject.renderer.material.color = Color.yellow;
	}else if(p.x < 2 && p.x > 0){
		gameObject.renderer.material.color = Color.blue;
	}else{
		gameObject.renderer.material.color = Color.red;
	}
	
}