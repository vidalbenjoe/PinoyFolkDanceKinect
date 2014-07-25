

function OnMouseEnter(){
renderer.material.color = Color.green;
}

function OnMouseExit(){
renderer.material.color = Color.white;
}

function OnMouseDown(){

Loading_Screen.LoadingScreenOn = true;

Application.LoadLevel("DanceChooser");


}