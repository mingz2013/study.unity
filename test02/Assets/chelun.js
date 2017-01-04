#pragma strict

function Start () {

}

function Update () {
	gameObject.transform.Rotate(0, -15 * Time.deltaTime, 0); // current Object   transform rotate by y with 15 every deltatime
}