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

using System.Runtime.InteropServices;
using System.IO;
using OmekFramework.Common.Main;
using OmekFramework.Beckon.Main;
using OmekFramework.Common.BasicTypes;
using OmekFramework.Beckon.Data;
using OmekFramework.Common.GeneralUtils;



public class GestureScript : MonoBehaviour {
	public GUITexture[] PerfectArray;
	
	
	
	public AudioSource applause;
	//public AudioSource applause;
	
	public GUIText ReadySetGo;
	public string loadLevel = "";
	
	public GUIText scoreText;
	public GUIText scoreText2;

	public int score = 0;


	public GUIStyle gui1;
	

	public GUITexture perfTexture;
	public GUITexture missTexture;
	public GUITexture dancecompleteBoard;
	
	public Particle particlesss;
	
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
	
	
	

	// Set these variable for evry gestures
	public float gesturetime0 = 0.0f;
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
	
 	public float PerfTextTimer = 0.0f;
	public float MissTextTimer = 0.0f;
	
	public float displaycomplete = 0.0f;
	
	
	//--------------------------------------------------------------------
	//start of gesture window


	//----End of Gestures Window
	
	//this statement will call the Initialize unction
	

	
	 void Awake(){
	
		perfTexture.enabled = false;
		missTexture.enabled = false;
		//BeckonSessionConfiguration sessionConf = new BeckonSessionConfiguration();
		//Enabling the Gesture and registering to beckonManager
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_firststep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_seventhstep");
		

				 }
	

// 
	//------------------------------
	// Use this for initialization
	void Start () {
		perfTexture.enabled = false;
		missTexture.enabled = false;
		scoreText2.enabled = false;
		dancecompleteBoard.enabled = false;
		applause.audio.enabled = false;
	
		
	
		PlayerPrefs.SetInt("CurrentScore", 0);
		

			//BeckonManager.BeckonInstance.Gestures.RegisterOnGesture
		
		
		
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep_mir");
	
		

	}
	
	//set the texture for every gesture
	
	
	// Update is called once per frame
	//after 17 seconds enable the displayed gesture on the right side of the screen

	void Update () {
		
		
		 scoreText.text = PlayerPrefs.GetInt("CurrentScore", 0).ToString();
		//countdowntime
		Ready -= Time.deltaTime;
		Three -= Time.deltaTime;
		Two -= Time.deltaTime;
		One -= Time.deltaTime;
		Go -= Time.deltaTime;
		
		DisableReadySetGo -= Time.deltaTime;
		
		//Time for gestures
		
		gesturetime0 -= Time.deltaTime;
		gesturetime1 -= Time.deltaTime;
		gesturetime2 -= Time.deltaTime;
		gesturetime3 -= Time.deltaTime;
		gesturetime4 -= Time.deltaTime;
		gesturetime5 -= Time.deltaTime;
		gesturetime6 -= Time.deltaTime;
		gesturetime7 -= Time.deltaTime;
		gesturetime8 -= Time.deltaTime;
		gesturetime9 -= Time.deltaTime;
		gesturetime10 -= Time.deltaTime;
		gesturetime11 -= Time.deltaTime;
		gesturetime12 -= Time.deltaTime;
		gesturetime13 -= Time.deltaTime;
		
		//PerfTextTimer -= Time.deltaTime;
	
		displaycomplete -= Time.deltaTime;
		
		GameEndTime -= Time.deltaTime;
	
		
		if(Ready <=0){
			ReadySetGo.text = "Ready!";
		}
		
		if(Three <=0){
			ReadySetGo.text = "3";
		}
		
		if(Two <=0){
			ReadySetGo.text = "2";
		}
		
		if(One <=0){
			ReadySetGo.text = "1";
		}
		
		if(Go <=0){
			ReadySetGo.text = "Go!!";
		}
		
		if(DisableReadySetGo <=0){
			ReadySetGo.text = "";
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
	
			if(gesturetime0 == 0)  {
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
		
	
			
			
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
		 		//if the player gesture match with the gesture "leftclick"
				//after a seconds Disable the gesture
				
			AddScore();
			perfTexture.enabled = true;
			if(MissTextTimer ==0){
			MissTextTimer -= Time.deltaTime;
			missTexture.enabled = false;
			perfTexture.enabled = true;
				}
				}
			
			else {
		//animation.Play("missAnimate");
	//		missTexture.enabled = true;	
				
			perfFuctionTimerElse();
			}
			
			}
		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false) {
				missTexture.enabled = true;
		}
		
		//------------------------------------------------------------------------------------------>
		//                   				- SECOND GESTURE -
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		//activate the next gesture after the first gesture
		 if(gesturetime1 <= 0.0f) {
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
			//BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_thirdstep");
		
	
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==true) {
		 		
			AddScore();
					perfTexture.enabled = true;
				if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
		//	animation.Play("missAnimate");
			perfFuctionTimerElse();
			}
		
			}
		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==false){
				missTexture.enabled = true;
		}
		
		
		//------------------------------------------------------------------------------------------>
		//                   				- THIRD GESTURE -
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		
		 if(gesturetime2 == 0.0f){
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			
			
			
			
		
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
		 		
			AddScore();
					perfTexture.enabled = true;
				if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
		
			perfFuctionTimerElse();
			}
			}
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
			missTexture.enabled = true;
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
					perfTexture.enabled = true;
					if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
		
			perfFuctionTimerElse();
			}
		
			}
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
			missTexture.enabled = true;
		}
		
			//------------------------------------------------------------------------------------------>
		//                   				
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		
		 if(gesturetime4 <= 0.0f){
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
					perfTexture.enabled = true;
				if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
		
			}
		
		
				//------------------------------------------------------------------------------------------>
		//                   			
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		
		
			 if(gesturetime5 <= 0.0f){
		
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
		
		
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
		 		
			AddScore();
					perfTexture.enabled = true;
					if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
			
			perfFuctionTimerElse();
			}
		
			}
		
		
		 if(gesturetime6 <= 0.0f){
			
		//	BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_firststep");
			//.BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_thirdstep");
		
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==true) {
		 		
			AddScore();
					perfTexture.enabled = true;
				if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
			}
		
		
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
					perfTexture.enabled = true;
					if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
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
					perfTexture.enabled = true;
				if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
		
			}
		
		
		 if(gesturetime9 <= 0.0f){
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
		
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
		 		
			AddScore();
					perfTexture.enabled = true;
				if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
			}
		
		 if(gesturetime10 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_slideleft");
		
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_slideleft",8)==true)  {
		 		
			AddScore();
					perfTexture.enabled = true;
					if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
			}
		
		
		 if(gesturetime11 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_slideright");
	
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_slideright",7)){
		 		
			AddScore();
					perfTexture.enabled = true;
					if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
			}
		
		
		 if(gesturetime12 <= 0.0f){

			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			
			
	
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
		 		
			AddScore();
					perfTexture.enabled = true;
				if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
			}
		
		
			 if(gesturetime13 <= 0.0f){
			//BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_firststep");
		//	BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_secondstep");
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_thirdstep");
		
			
		
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)) {
		 		
			AddScore();
					perfTexture.enabled = true;
					if(MissTextTimer <=0){
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				}
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
		}
		
		if(GameEndTime <= 0.0f){
			
			 GameOver();
		}
		
		
		if(displaycomplete<=0.0f){
			
			DisplayComplete();
		}

	}
	
	
	
	void RandomRightIndicator(){
		
		//call 
		
	}
	
	
	void RandomWrongIndicator(){
		
		//call this
		
	}
	
	
		  void AddScore()
    {
        int _tempScore = PlayerPrefs.GetInt("CurrentScore");
        _tempScore += 10;
        PlayerPrefs.SetInt("CurrentScore", _tempScore);
    }
	
	
	
		  void MinusScore()
    {
        int _tempScore = PlayerPrefs.GetInt("CurrentScore");
        _tempScore -= 5;
        PlayerPrefs.SetInt("CurrentScore", _tempScore);
    }
	
	
	void DisplayComplete(){
		scoreText.text = "";
		dancecompleteBoard.enabled = true;
		scoreText2.enabled =true;
		scoreText2.text = "" + PlayerPrefs.GetInt("CurrentScore");
		
		applause.audio.enabled = true;
	}
	
	 void GameOver()
    {
	 AutoFade.LoadLevel(loadLevel ,3,1,Color.black);
    }
	
	
	
	void perfFuctionTimerElse(){
	perfTexture.enabled = false;
		
	}
	
	
	
	
	
		
	
	
	
	
	
	//displaying Gestures
	void OnGUI () {
		GUI.skin.box = gui1;
		
		//GUILayout.BeginArea ( new Rect( Screen.width/2-Screen.width / 8, 10, Screen.width / 4, Screen.height /2 ) );
		////GUI.Label (Rect (25, 25, 100, 30), "Score:" + score.ToString()); 
        
		GUILayout.Box ("Score: ");
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
	











