#pragma strict

var xianbing:GameObject;

function Start () {

}

function Update () {
	if(Input.GetKeyUp(KeyCode.Space)){
		Instantiate(xianbing, gameObject.transform.position, gameObject.transform.rotation);
	}
}