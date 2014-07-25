#pragma strict


//eto po ung prefab ng character nmin :)
var player01Prefab : GameObject;
var player02Prefab : GameObject;



//this is where the script placed in the leve ..
//and saved by the playerPrefs 1,2,3 
//time Check 2:59AM..nakakaantok much!
var savedPlayer : int = 0;

function Awake () {
	//get the value and saved the data of the each player then get the integer value to load to the new game environment
	savedPlayer = PlayerPrefs.GetInt("selectedPlayer");
	
	player01Prefab = GameObject.Find("Player1");
	player02Prefab = GameObject.Find("Player2");
	
	
	if(savedPlayer == 0) //if we've not selected any player,load the player 1
	
		{
		player01Prefab.SetActiveRecursively(true);
		player02Prefab.SetActiveRecursively(false);
	
		}
		
	else if(savedPlayer ==1)//set the playerprefs,then
	{
		player01Prefab.SetActiveRecursively(true);
		player02Prefab.SetActiveRecursively(false);
		
	}
	
	
	else if(savedPlayer ==2)//set the playerprefs,then
	{
		player01Prefab.SetActiveRecursively(false);
		player02Prefab.SetActiveRecursively(true);
	
	}
	
	
				
}

