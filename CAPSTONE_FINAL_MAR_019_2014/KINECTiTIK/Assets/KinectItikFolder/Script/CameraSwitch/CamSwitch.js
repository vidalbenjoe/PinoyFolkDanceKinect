#pragma strict
public var camera1 : Camera;
public var camera2 : Camera;
var timer1 : float = 5.0;


function Start () {
camera1.camera.enabled = true;
camera2.camera.enabled = false;
}

function Update () {
timer1 -= Time.deltaTime;
if(timer1 <= 0){
camera1.camera.enabled = false;
camera2.camera.enabled = true;


}

}