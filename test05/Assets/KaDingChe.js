#pragma strict

var n:Transform;
//var p:Vector3;
var b:boolean;
//var max_x:float;
//var min_x:float;
function Start () {
	n = gameObject.GetComponent("Transform");
//	b = true;
//	max_x = 4.0;
//	min_x = -20.0;
}

function Update () {
//	p = n.position;	// get position
//	print("posiotion: " + p); 
//	
//	if(b){
//		p.x += 1;
//		if(p.x > max_x){
//			b = false;
//		}
//	}else{
//		p.x -= 1;
//		if(p.x < min_x){
//			b = true;
//		}
//	}
//	
//	
//	
//	n.position = p;	// set position 

	b = Input.GetKey(KeyCode.W);
	if(b){
		n.Translate(1 * Time.deltaTime, 0, 0, Space.Self);
	}
	
	b = Input.GetKey(KeyCode.S);
	if(b){
		n.Translate(-1 * Time.deltaTime, 0, 0, Space.Self);
	}
	
	b = Input.GetKey(KeyCode.A);
	if(b){
		n.Rotate(0, -25 * Time.deltaTime, 0, Space.Self);
	}
	
	b = Input.GetKey(KeyCode.D);
	if(b){
		n.Rotate(0, 25 * Time.deltaTime, 0, Space.Self);
	}
}