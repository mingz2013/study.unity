#pragma strict
var speed:int;
function Start () {
speed = 100;
}

function Update () {
	gameObject.transform.Rotate(0, speed * Time.deltaTime, 0); 
}