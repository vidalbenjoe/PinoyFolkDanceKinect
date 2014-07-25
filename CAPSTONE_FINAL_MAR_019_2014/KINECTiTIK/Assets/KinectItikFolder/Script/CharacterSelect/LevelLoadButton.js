//this is the load button


function OnGUI(){

GUI.Box (Rect (10,10,100,90), "Load Game");

//make the first button
if(GUI.Button(Rect (20,40,80,20), "Start The Game")){



Application.LoadLevel("MainGame");

}
}