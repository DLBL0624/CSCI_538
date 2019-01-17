#pragma strict
var startPosition = Vector3.zero;
var tmpMoveTan = Vector3.zero;
var tmpValue = 0.1;
var tmpTran = Vector3.zero;
var moveSpeed = 0.3;    //original 0.7
var dists:float;
var rotate_value = 10;
var ani:Animation;
var controller : CharacterController;
function Start () {
	startPosition = transform.position;
	ani = GetComponent(Animation);
	controller = GetComponent(CharacterController);
}

function Update () {
	//计算游动距离
	var dist = Vector3.Distance(startPosition, transform.position);
	ani.Play();
	dists = Vector3.Distance(tmpTran, transform.position);
	tmpTran = transform.position;
	if (dists < 0.01) {
		tmpMoveTan = Vector3.forward;// forward vector
		tmpMoveTan = transform.TransformDirection(tmpMoveTan);
        tmpMoveTan *= 1;
        controller.Move(tmpMoveTan * Time.deltaTime);
        if (tmpValue > 0.5) {
			transform.Rotate(0,rotate_value,0);
		} else {
			transform.Rotate(0,-rotate_value,0);
		}
		return;
	}
	if (dist > 2) {//游动距离超过1米开始停歇
		tmpMoveTan = Vector3.forward;
		tmpMoveTan = transform.TransformDirection(tmpMoveTan);
        tmpMoveTan *= moveSpeed;
        controller.Move(tmpMoveTan * Time.deltaTime);
		if (dist >4) {//超过2米开始掉头
			if (tmpValue > 0.5) {
				transform.Rotate(Vector3.up * Time.deltaTime*rotate_value);
			} else {
				transform.Rotate(-Vector3.up * Time.deltaTime*rotate_value);
			}
		}
/*
		if (dist > 2) {
			startPosition = transform.position;
			//生成随机数
			tmpValue = Random.value;
		}
*/
	} else {
	 	tmpMoveTan = Vector3.forward;
		tmpMoveTan = transform.TransformDirection(tmpMoveTan);
        tmpMoveTan *= moveSpeed+0.3;
        controller.Move(tmpMoveTan * Time.deltaTime);
	}
}