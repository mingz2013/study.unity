#pragma strict

function Start () {

}

function Update () {
//	if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
//		gameObject.transform.Rotate(0, 15 * Time.deltaTime, 0, Space.Self);
//	}
//	if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
//		gameObject.transform.Rotate(0, -15 * Time.deltaTime, 0, Space.Self);
//	}

gameObject.transform.Rotate(0,  Input.GetAxisRaw("ChanPinKongZhi") * 15 * Time.deltaTime, 0, Space.Self);

}