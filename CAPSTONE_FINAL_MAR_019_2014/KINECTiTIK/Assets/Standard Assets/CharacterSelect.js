#pragma strict
//this is the currently selected Player. also the one that will be saved to playerPrefs
var sL1 : Light;
var sL2 : Light;
var selectedPlayer : int = 0;


function Start(){
sL1.active = false;
sL2.active = false;
}



function Update () {

if(Input.GetMouseButtonUp (0)){
		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		var hit : RaycastHit;
		
		
		if (Physics.Raycast (ray, hit, 100))
		{
		
					if(hit.collider.name == "Player1"){
					SelectedCharacter1();//Send this click down  to a function called "SelectedCharacter1().
					sL1.active = true;
					sL2.active = false;
					
					}
					
					if(hit.collider.name == "Player2"){
					SelectedCharacter2();
					sL1.active = false;
					sL2.active = true;
					}
					
				
		}
		else
		{
		return;
		}
		}
		}
	//make it public so this function can be access from CSharp	
public function SelectedCharacter1(){
selectedPlayer = 1;
PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));

//call animation for the player
}

public function SelectedCharacter2(){

selectedPlayer = 2;
PlayerPrefs.SetInt("selectedPlayer", (selectedPlayer));



}
	



