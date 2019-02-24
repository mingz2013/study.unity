#pragma strict

var b:boolean;
var v:Vector3;

function Start () {
	b = false;
}

function Update () {
	b = Input.anyKey;		// 
	v = Input.mousePosition;
	print("b: " + b + ", v: " + v);
}