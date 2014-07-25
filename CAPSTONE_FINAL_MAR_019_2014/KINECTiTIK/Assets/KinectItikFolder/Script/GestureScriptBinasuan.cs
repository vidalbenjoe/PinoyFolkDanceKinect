//By: Benjoe Rivera Vidal
//June - August 2013
//Capstone Project 2013
//Technological Institute of the Philippines
//www.benjoeriveravidal.businesscatalyst.com/
//last update January 12, 2014

//Logs
//as of January 23, 2013
// dance complete scoring added
//-miss or perfect added
//-display complte timer
// -ready set and go indicator


//try the "== 0"(not <= 0.0f or == 0.0f assignment operator in every gesturetimeX

using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;
using System.IO;
using OmekFramework.Common.Main;
using OmekFramework.Beckon.Main;
using OmekFramework.Common.BasicTypes;
using OmekFramework.Beckon.Data;
using OmekFramework.Common.GeneralUtils;



public class GestureScriptBinasuan : MonoBehaviour {
	public GameObject scoreObject;
	private ScoreIndicator scoreIndScript; 
	
	public bool showBox = true;
	
	
	public AudioSource applause;
	//public AudioSource applause;
	
	public GUIText ReadySetGo;
	public string loadLevel = "";
	
	public GUIText scoreText;
	public GUIText scoreText2;

	public int score = 0;
	public GUIStyle gui1;
	

	
	public GUITexture dancecompleteBoard;
	
	
	
	//public GUIStyle gui1;
	//<-------------------marquee behavior
	
	public string message	 = "The itik-itik is a dance from Surigao, in which the movements of a duck are imitated. An 'itik' is a species of duck. ";
	public float scrollSpeed = 50;
 	Rect messageRect;
	
	
	//	Set this time for a countdowntimer before the games start
	public float Ready = 0.0f;
	public float Three = 0.0f;
	public float Two= 0.0f;
	public float One = 0.0f;
	public float Go = 0.0f;
	public float DisableReadySetGo = 0.0f;
	
	public bool DecreaseReady = true;
	public bool DecreaseThree = true;
	public bool DecreaseTwo = true;
	public bool DecreaseOne = true;
	public bool DecreaseGo = true;
	public bool DecreaseDisableReadySetGo = true;
	
	public bool DecreaseTime0 = true;
	public bool DecreaseTime1 = true;
	public bool DecreaseTime2 = true;
	public bool DecreaseTime3 = true;
	public bool DecreaseTime4 = true;
	public bool DecreaseTime5 = true;
	public bool DecreaseTime6 = true;
	public bool DecreaseTime7 = true;
	public bool DecreaseTime8 = true;
	public bool DecreaseTime9 = true;
	public bool DecreaseTime10 = true;
	public bool DecreaseTime11= true;
	public bool DecreaseTime12 = true;
	public bool DecreaseTime13 = true;

	// Set these variable for evry gestures
	public float gesturetime0 = -10.0f;
	public float gesturetime1 = 0.0f;
	public float gesturetime2 = 0.0f;
	public float gesturetime3 = 0.0f;
	public float gesturetime4 = 0.0f;
	public float gesturetime5 = 0.0f;
	public float gesturetime6 = 0.0f;
	public float gesturetime7 = 0.0f;
	public float gesturetime8 = 0.0f;
	public float gesturetime9 = 0.0f;
	public float gesturetime10 = 0.0f;
	public float gesturetime11 = 0.0f;
	public float gesturetime12 = 0.0f;
	public float gesturetime13 = 0.0f;
	
	public float GameEndTime = 0.0f;
	public float displaycomplete = 0.0f;
	
	
	//--------------------------------------------------------------------
	//start of gesture window

	
	
	
	

	//----End of Gestures Window
	
	//this statement will call the Initialize unction
	

	
	 void Awake(){
		
		//BeckonSessionConfiguration sessionConf = new BeckonSessionConfiguration();
		//Enabling the Gesture and registering to beckonManager
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_firststep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_seventhstep");
		
		scoreIndScript = scoreObject.GetComponent<ScoreIndicator>();
		

	//	scoreIndScript.FollowtheStep.enabled = true;
//		GetComponent<ScoreIndicator>().Miss.enabled = true;

		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("wrongmovegesture",10)==true)  {
			scoreIndScript.MissBad();
					}
		
		
		
				 }
	

// 
	//------------------------------
	// Use this for initialization
	void Start () {
				
	
		PlayerPrefs.SetInt("CurrentScore", 0);
		//GetComponent<ScoreIndicator>().Start();
		
		
		//perfTexture.enabled = false;
		//missTexture.enabled = false;
		scoreText2.enabled = false;
		dancecompleteBoard.enabled = false;
		applause.audio.enabled = false;
		
		
		
		DecreaseReady = true;
		DecreaseThree= true;
		DecreaseTwo = true;
		DecreaseOne = true;
		DecreaseGo = true;
		DecreaseDisableReadySetGo = true;
		
		
		DecreaseTime0 = true;
		DecreaseTime1 = true;
		DecreaseTime2 = true;
		DecreaseTime3 = true;
		DecreaseTime4 = true;
		DecreaseTime5 = true;
		DecreaseTime6 = true;
		DecreaseTime7 = true;
		DecreaseTime8 = true;
		DecreaseTime9 = true;
		DecreaseTime10 = true;
		DecreaseTime11 = true;
		DecreaseTime12 = true;
		DecreaseTime13 = true;
		
		
	
		

			//BeckonManager.BeckonInstance.Gestures.RegisterOnGesture
		
			//from 0-16 seconds hide the gestures
		   
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep_mir");
	
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("wrongmovegesture");

		
		
		
		
	}
	
	
	// Update is called once per frame
	//after 17 seconds enable the displayed gesture on the right side of the screen

	void Update () {
		 scoreText.text = PlayerPrefs.GetInt("CurrentScore", 0).ToString();
		
	
		
		//countdowntime
		if(DecreaseReady ==true){
			Ready -= Time.deltaTime;
		}
		if(DecreaseThree ==true){
			Three -= Time.deltaTime;	
		}
		if(DecreaseTwo ==true){
			Two -= Time.deltaTime;
		}
		if(DecreaseOne == true){
			One -= Time.deltaTime;
		}
		if(DecreaseGo == true){
		Go -= Time.deltaTime;
		}
		if(DecreaseDisableReadySetGo == true){
		DisableReadySetGo -= Time.deltaTime;
		}
		
			//Time for gestures
			if(DecreaseTime0 == true){
				gesturetime0 -= Time.deltaTime;
			}
			if(DecreaseTime1 == true){
				gesturetime1 -= Time.deltaTime;
			}
			if(DecreaseTime2 == true){
				gesturetime2 -= Time.deltaTime;
			}
			if(DecreaseTime3 == true){
				gesturetime3 -= Time.deltaTime;
			}
			if(DecreaseTime4 == true){
				gesturetime4 -= Time.deltaTime;
			}
			if(DecreaseTime5 == true){
				gesturetime5 -= Time.deltaTime;
			}
			if(DecreaseTime6 == true){
				gesturetime6 -= Time.deltaTime;
			}
			if(DecreaseTime7 == true){
				gesturetime7 -= Time.deltaTime;
			}
			if(DecreaseTime8 == true){	
				gesturetime8 -= Time.deltaTime;
			}
			if(DecreaseTime9 == true){
				gesturetime9 -= Time.deltaTime;
			}
			if(DecreaseTime10 == true){
				gesturetime10 -= Time.deltaTime;
			}
			if(DecreaseTime11 == true){
				gesturetime11 -= Time.deltaTime;
			}
			if(DecreaseTime12 == true){
				gesturetime12 -= Time.deltaTime;
			}
			if(DecreaseTime13 == true){
				gesturetime13 -= Time.deltaTime;
			}
		
		//PerfTextTimer -= Time.deltaTime;
	
		displaycomplete -= Time.deltaTime;
		
		GameEndTime -= Time.deltaTime;
	
	
		
		
		if(Ready <=0){
			ReadySetGo.text = "Ready!";
			DecreaseReady = false;
		}
		
		if(Three <=0){
			ReadySetGo.text = "3";
			DecreaseThree = false;
		}
		
		if(Two <=0){
			ReadySetGo.text = "2";
			DecreaseTwo = false;
		}
		
		if(One <=0){
			ReadySetGo.text = "1";
			DecreaseOne =false;
		}
		
		if(Go <=0){
			ReadySetGo.text = "Go!!";
			DecreaseGo =false;
		}
		
		if(DisableReadySetGo <=0){
			ReadySetGo.text = "";
			DecreaseDisableReadySetGo =false;
		}
		
		
		//In order to check for an alert in unity script,  add the following lines 
		if (BeckonManager.BeckonInstance.Alerts.IsAlertActive(Omek.AlertEventType.Alert_PlayerLeaves)){
		//trigger the pause event		
		
		}
		
		//<--------------------------------- switching timer para sa first gesture------------------
		
		//------------------------------------------------------------------------------------------>
		//                   				- FIRST GESTURE -
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
	
	
			if(gesturetime0 < 0.0f )  {
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");//this line will enable the first gesture within the time duration
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
	
				
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {// this line will call the gesture and match to the recorded gesture
		 		AddScore();// add the score
		
				scoreIndScript.PerfectGood();
				}
			if((gesturetime0 < -3.50f)&&(gesturetime0 < -5.0f)){
						
				scoreIndScript.MissBad();
				MinusScore();
			}
		
			}//
		

		else if((gesturetime0 < -7.50f) && (gesturetime0 < -9.0f  )) {
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
			scoreIndScript.PerfectGood();
			}
					
		else if((gesturetime0 < -8.50f) && (gesturetime0 < -9.0f  ))  {
				scoreIndScript.MissBad();
				scoreIndScript.HidePerfect();
			}
			
		}
		
		if(gesturetime0 <= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime0 = false;
				scoreIndScript.HidePerfect();
				scoreIndScript.MissBad();
				PauseTimer0();
			}
		
		
		
		//------------------------------------------------------------------------------------------>
		//                   				- SECOND GESTURE -
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		//activate the next gesture after the first gesture
		 if(gesturetime1 <= 0.0f) {
				
					BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
					BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_thirdstep");
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_secondstep");
				
				if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",3)==true))  {
		 		
					AddScore();
					scoreIndScript.PerfectGood();
					if((gesturetime1 < -6.0f)&&(gesturetime1 < -8.0f)){
					scoreIndScript.MissBad();
						
			}
		
				
				}
			}//
			
				else if((gesturetime1 < -9.0f) && (gesturetime1 < -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==true)  {
					scoreIndScript.PerfectGood();
					AddScore();
				
			}
					
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==false)  {
					
					scoreIndScript.MissBad();
					MinusScore();
				
			}
			
		}
		
		if(gesturetime1 <= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime1 = false;
				scoreIndScript.HidePerfect();
				PauseTimer1();
				scoreIndScript.MissBad();
			}
		
		
	
		
		//------------------------------------------------------------------------------------------>
		//                   				- THIRD GESTURE -
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		
		 if(gesturetime2 < 0.0f){
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
		 		
					AddScore();
				scoreIndScript.PerfectGood();
						if((gesturetime2 < -6.0f)&&(gesturetime2 < -8.0f)){
					scoreIndScript.MissBad();
						MinusScore();
					
			}
				}
				}//
			
			
		
				else if((gesturetime2 < -7.50f) && (gesturetime2 < -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
			scoreIndScript.PerfectGood();
					AddScore();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstepitikitik_fourthstep",3)==false)  {
					scoreIndScript.MissBad();
					MinusScore();
			}
			
		}
		
		if(gesturetime2 <= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime2 = false;
				PauseTimer2();
				scoreIndScript.HidePerfect();
			scoreIndScript.MissBad();	
			}
		
	
			
	
			//------------------------------------------------------------------------------------------>
		//                   				- FOURTH GESTURE -
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		 if(gesturetime3 <= 0.0f){
				
						
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep_mir");
			
			//-------------------------------------CALL THE FOURTH GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
		 		//if the player gesture match with the gesture "leftclick"
				//after a seconds Disable the gesture
					AddScore();
					scoreIndScript.PerfectGood();
					if((gesturetime3 < -6.0f)&&(gesturetime3 < -8.0f)){
				
					scoreIndScript.MissBad();
					MinusScore();
			}
				}
					}
			
	
				else if((gesturetime3 < -7.50f) && (gesturetime3 < -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
					scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				 		scoreIndScript.MissBad();
					MinusScore();
				
			}
			
		}
		
		if(gesturetime3 <= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime3 = false;
				PauseTimer3();
				scoreIndScript.HidePerfect();
			
			}
		
		
		
			//------------------------------------------------------------------------------------------>
		//                   				
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		
		 if(gesturetime4 <= 0.0f) {
							
				
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_seventhstep");
			
			
				
			//-----------------------------------------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
		 		//if the player gesture match with the gesture "leftclick"
				//after a seconds Disable the gesture
			AddScore();
					scoreIndScript.PerfectGood();
				
					if((gesturetime4 < -6.0f)&&(gesturetime4 < -8.0f)){
					scoreIndScript.MissBad();
					
					}
			}
				
				}
			
			else if((gesturetime4 <= -7.50f) && (gesturetime4 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
					scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
			scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime4 <= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime4 = false;
				PauseTimer4();
				scoreIndScript.HidePerfect();
				scoreIndScript.MissBad();
			}
		
		
				//------------------------------------------------------------------------------------------>
		//                   			
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		
		
			 if(gesturetime5 <= 0.0f){
				
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
		 		
				AddScore();
				scoreIndScript.PerfectGood();
					if((gesturetime5 < -6.0f)&&(gesturetime5 < -8.0f)){
					scoreIndScript.MissBad();
					MinusScore();
					}
				}
				}
			
			else if((gesturetime5<= -8.50f) && (gesturetime5 <= -9.50f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
					scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==false)  {
					scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime5 <= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime5 = false;
				PauseTimer5();
				scoreIndScript.HidePerfect();
				scoreIndScript.MissBad();
			}
		
		//--------------------------------------------------------===============================================
		
		 if(gesturetime6 <= 0.0f) {
			
			//BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_firststep");
			//.BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_thirdstep");
		
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==true) {
		 		
						AddScore();
						scoreIndScript.PerfectGood();
				
					if((gesturetime6 < -4.0f)&&(gesturetime6 < -6.0f)){
					scoreIndScript.MissBad();
					
					}
				}
				}
			
			else if((gesturetime6<= -8.50f) && (gesturetime6 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==true)  {
					scoreIndScript.PerfectGood();
				
			}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==false)  {
				 scoreIndScript.MissBad();
					MinusScore();
				
			}
			
		}
		
		if(gesturetime6 <= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime6 = false;
				PauseTimer6();
			
				scoreIndScript.MissBad();
				MinusScore();
			}
			
			
			///////////-------------------------------------------------
		
		 if(gesturetime7 <= 0.0f){
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_seventhstep");
			
				
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
		 		
					AddScore();
					scoreIndScript.PerfectGood();
				
				
					if((gesturetime7< -2.0f)&&(gesturetime7 < -4.0f)){
					scoreIndScript.MissBad();
					
					}
				}
		}//
			
		
				else if((gesturetime7<= -8.50f) && (gesturetime7 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
						scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				 	 scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime7<= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime7 = false;
				PauseTimer7();
				scoreIndScript.HidePerfect();
				 scoreIndScript.MissBad();
			MinusScore();
			}
		
		
		
		
		
		
		 if(gesturetime8 <= 0.0f){
				
				
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_seventhstep");
			
			
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
		 		
			AddScore();
				scoreIndScript.PerfectGood();
				
					if((gesturetime8 < -3.0f)&&(gesturetime8 < -4.0f)){
					scoreIndScript.MissBad();
					MinusScore();
					
					}
				}
				}
			
			else if((gesturetime8<= -7.50f) && (gesturetime8 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
					 scoreIndScript.MissBad();
				MinusScore();
				
			}
			
		}
		
		if(gesturetime8<= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime8 = false;
				PauseTimer8();
				scoreIndScript.PerfectGood();
			}
		
		
		
		
		
		 if(gesturetime9 <= 0.0f){
				
				
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
		 		
			AddScore();
				scoreIndScript.PerfectGood();
				
					if((gesturetime9 < -3.0f)&&(gesturetime9 < -5.0f)){
					scoreIndScript.MissBad();
				
					}
				
				}
				}
			
			
			else if((gesturetime9<= -7.50f) && (gesturetime9 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
					scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				 		 scoreIndScript.MissBad();
				MinusScore();
				
			}
			
		}
		
		if(gesturetime9<= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime9 = false;
				PauseTimer9();
				scoreIndScript.HideWrong();
				scoreIndScript.PerfectGood();
			}
			
			
			
		
		 if(gesturetime10 <= 0.0f) {
				
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_slideleft");
		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_slideleft",8)==true)  {
		 		
						AddScore();
						scoreIndScript.PerfectGood();
				
					if((gesturetime10 < -4.0f)&&(gesturetime10 < -7.0f)){
					scoreIndScript.MissBad();
			MinusScore();
					}
				}
				}
				else if((gesturetime10<= -7.50f) && (gesturetime10 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_slideleft",8)==true)  {
					scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_slideleft",8)==false)  {
				 	 scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime10 <= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime10 = false;
				PauseTimer10();
			 scoreIndScript.MissBad();
			
			}
				
		
		
		
		
		
		 if(gesturetime11 <= 0.0f) {
			
				
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_slideright");
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_slideright",7)){
		 		
			AddScore();
					scoreIndScript.PerfectGood();
				
				}
				}
			
					else if((gesturetime11<= -7.50f) && (gesturetime11 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_slideright",7)==true)  {
				scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_slideright",7)==false)  {
			 	 scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime11<= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime11 = false;
				PauseTimer11();
				scoreIndScript.HidePerfect();
				 scoreIndScript.MissBad();
			}
			
			
			
			
		 if(gesturetime12 <= 0.0f) {
				

			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_thirdstep");
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==true)  {
		 		
			AddScore();
					scoreIndScript.PerfectGood();
				}
				}
			else if((gesturetime12<= -7.50f) && (gesturetime12 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==true)  {
				scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==false)  {
				 scoreIndScript.MissBad();
				MinusScore();
				
			}
			
		}
		
		if(gesturetime12<= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime12= false;
				PauseTimer12();
				scoreIndScript.HidePerfect();
				scoreIndScript.HideWrong();
			}
		//////////================LAST GESTURE==============/////////
		
			 if(gesturetime13 <= 0.0f) {
				
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)) {
		 		
				AddScore();
			scoreIndScript.PerfectGood();
				}
				}
			
				else if((gesturetime13<= -7.50f) && (gesturetime13 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
				scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==false)  {
					 scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime13<= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime13= false;
				PauseTimer13();
				scoreIndScript.HidePerfect();
				scoreIndScript.HideWrong();
			}
		
			
		
		
		if(GameEndTime <= 0.0f){
			
			 GameOver();
		}
		
		
		if(displaycomplete<=0.0f){
			
			DisplayComplete();
			
		}

	}
	
		  void AddScore()
    {
        int _tempScore = PlayerPrefs.GetInt("CurrentScore");
        _tempScore += 8;
        PlayerPrefs.SetInt("CurrentScore", _tempScore);
    }
	
	
	
		  void MinusScore()
    {
        int _tempScore = PlayerPrefs.GetInt("CurrentScore");
        _tempScore -= 2;
        PlayerPrefs.SetInt("CurrentScore", _tempScore);
    }
	
	
	void DisplayComplete(){
		scoreText.text = "";
		dancecompleteBoard.enabled = true;
		scoreText2.enabled =true;
		scoreText2.text = "" + PlayerPrefs.GetInt("CurrentScore");
		showBox = false;
		applause.audio.enabled = true;
	}
	
	 void GameOver()
    {
	 AutoFade.LoadLevel(loadLevel ,3,1,Color.black);
    }
	
	
	
	void PauseTimer0(){
		gesturetime0 = 0.0f;
	}
	
		void PauseTimer1(){
		gesturetime1 = 0.0f;
	}
	
		void PauseTimer2(){
		gesturetime2 = 0.0f;
	}
	
		void PauseTimer3(){
		gesturetime3 = 0.0f;
	}
	
		void PauseTimer4(){
		gesturetime4 = 0.0f;
	}
	
		void PauseTimer5(){
		gesturetime5= 0.0f;
	}
	
		void PauseTimer6(){
		gesturetime6 = 0.0f;
	}
	
	
		void PauseTimer7(){
		gesturetime7 = 0.0f;
	}
	
		void PauseTimer8(){
		gesturetime8 = 0.0f;
	}
	
		void PauseTimer9(){
		gesturetime9 = 0.0f;
	}
	
		void PauseTimer10(){
		gesturetime10 = 0.0f;
	}
	
		void PauseTimer11(){
		gesturetime11 = 0.0f;
	}
	
		void PauseTimer12(){
		gesturetime12 = 0.0f;
	}
	
		void PauseTimer13(){
		gesturetime13 = 0.0f;
	}
	
	
	
	
	//displaying Gestures
	void OnGUI () {
		GUI.skin.box = gui1;
		
		//GUILayout.BeginArea ( new Rect( Screen.width/2-Screen.width / 8, 10, Screen.width / 4, Screen.height /2 ) );
		////GUI.Label (Rect (25, 25, 100, 30), "Score:" + score.ToString()); 
        
		if(showBox){
		
		GUILayout.Box ("Score: ");
		}
        //GUILayout.EndArea ();

                   
 		//<----------------------------Marquee Behavior
		
		if (messageRect.width == 0) {
			Vector2 dimensions = GUI.skin.label.CalcSize(new GUIContent(message));
 
			// Start the message past the left side of the screen
			messageRect.x      = -dimensions.x;
			messageRect.width  =  dimensions.x;
			messageRect.height =  dimensions.y;
		}
 
		messageRect.x += Time.deltaTime * scrollSpeed;
 
		// If the message has moved past the right side, move it back to the left
		if (messageRect.x > Screen.width) {
			messageRect.x = -messageRect.width;
		}
 
		GUI.Label(messageRect, message);
		
		
	}
		//--------------------------->
	
	
	
	}
	











