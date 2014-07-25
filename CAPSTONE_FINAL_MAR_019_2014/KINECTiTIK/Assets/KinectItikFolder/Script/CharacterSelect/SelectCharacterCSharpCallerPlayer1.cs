using UnityEngine;
using System.Collections;
//this script will call the SelectedCharacter function from Javasript using HotSpotbutton Kinect

	
	
		
	

public class SelectCharacterCSharpCallerPlayer1 : MonoBehaviour {
	public CharacterSelect jsScript;   
		public string levelToLoad = "";
	

	// Use this for initialization
	void Awake()
    {
		//Get the JavaScript component
	 jsScript = this.GetComponent<CharacterSelect>();//Don't forget to place the 'JS1' file inside the 'Standard Assets' folder
		
     
	
    }
	
	
	void OnButtonClick()
    {
   
       Application.LoadLevel(levelToLoad);
	  jsScript.SelectedCharacter1();
    }
	
	
	
	
	
}
