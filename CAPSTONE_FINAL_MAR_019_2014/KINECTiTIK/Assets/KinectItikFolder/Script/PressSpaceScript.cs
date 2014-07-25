using UnityEngine;
using System.Collections;

public class PressSpaceScript : MonoBehaviour {
	public TextMesh readyText;
	public GUIText readyGo;
	public float readyTextTime = 2.0f;
	public float cameraSwitch1 = 0.0f;
	public float cameraSwitch2 = 0.0f;
	
	public Camera Maincamera;
	public Camera camera2;
	public Camera camera3;
	
	public GameObject curtain1;
	public GameObject curtain2;
	
	public float countDownText3 = 0.0f;
	public float countDownText2 = 0.0f;
	public float countDownText1 = 0.0f;
	public float countDownTextGo = 0.0f;
	public float countDownTextBlankLang = 0.0f;
	// Use this for initialization
	void Start () {
		
	
	   
		readyText.renderer.enabled = true;
		camera2.enabled = false;
		Maincamera.enabled = true;
		camera3.enabled = false;
	//pause muna dito..then the user click the space bar..it will disable the text mesh then the game will automatically start
	}
	
	// Update is called once per frame
	void Update () {
	cameraSwitch1 -= Time.deltaTime;
	cameraSwitch2 -= Time.deltaTime;
		countDownText3 -= Time.deltaTime;
		countDownText2 -= Time.deltaTime;
		countDownText1 -= Time.deltaTime;
		countDownTextGo -= Time.deltaTime;
		countDownTextBlankLang -= Time.deltaTime;
	
		
	if(cameraSwitch1 <= 0){
			//AudioListener.pause = false;
			Maincamera.enabled = true;
			camera3.enabled = false;
			camera2.enabled = false;
			
			
		
			//Time.timeScale = 1;
		
	}
		
		
		if(cameraSwitch2 <= 0){
			Maincamera.enabled = true;
			camera3.enabled = false;
		    camera2.enabled = false; 
			//curtain1.animation.Play();
			//curtain2.animation.Play();
		}	
		
		if(countDownText3 < 0){
	
			
		readyGo.text = "3";
				
			}
		
		if(countDownText2 < 0){
	
			
		readyGo.text = "2";
				
			}
		
		
		if(countDownText1 < 0){
	
			
	readyGo.text = "1";
				
			}
		
		if(countDownTextGo < 0){
	
			
		  readyGo.text = "Go...";
				
			}
		
		
		if(countDownTextBlankLang < 0){
	
			
		  readyGo.text = "";
				
			}
		
	}
		
	
		
	
	  	

			
	
	
	
//	private IEnumerator readySetGoTimer( float wait )
//{
//	readyGo.text = "Ready!";
//   	 	yield return new WaitForSeconds(wait);
//		
//    
//    	yield return new WaitForSeconds(wait);
//  	
//    	yield return new WaitForSeconds(wait);
//    
//		yield return new WaitForSeconds(wait);
//  
//		yield return new WaitForSeconds(wait);
//    readyGo.text = "";
//		//
//	}
	
	
	

	
            
	}

