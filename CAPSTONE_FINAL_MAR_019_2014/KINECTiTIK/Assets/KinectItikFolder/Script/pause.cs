using System;
using UnityEngine;
 
public class pause : MonoBehaviour
{
    bool paused = false;
    public TextMesh readyText;
	
	
	void start(){
		 
	   AudioListener.pause = false;
	  

		
	}
	
	void Update(){
		
	}
	
 
}