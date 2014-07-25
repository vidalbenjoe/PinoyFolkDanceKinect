using UnityEngine;
using System.Collections;
using OmekFramework.Beckon.Main;
using System;
using System.Runtime.InteropServices;
using System.IO;
using OmekFramework.Common.Main;


public class KuratsaNo : MonoBehaviour {
	public GameObject scoreObject;
	private ScoreIndicator scoreIndScript; 
	
	
	public AudioSource applause;
	public bool showBox = true;
	
	public GUIText ReadySetGo;
	public string loadLevel = "";
	
	public GUIText scoreText;
	public GUIText scoreText2;
	
	public int score = 0;
	
	public GUIStyle gui1;
	

	public GUITexture perfTexture;
	public GUITexture missTexture;
	public GUITexture dancecompleteBoard;
	
	
	//public GUIStyle gui1;
	//<-------------------marquee behavior
	
	public string message	 = "The Kuratsa is highly favored by the Visayan people especially the Waray people of the Eastern Visayas region in the Philippines and highlights every important occasion in the Eastern Visayas communities.. ";
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
	
	
	public bool Decrease17to30 = true;
	public bool DecreaseTimeHalf = true;
	public bool Decrease41to60 = true;
	
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
	public bool DecreaseTime14 = true;
	public bool DecreaseTime15 = true;
	public bool DecreaseTime16 = true;
	
	
	
	public bool DecreaseTime31 = true;
	public bool DecreaseTime32 = true;
	public bool DecreaseTime33 = true;
	public bool DecreaseTime34 = true;
	public bool DecreaseTime35 = true;
	public bool DecreaseTime36 = true;
	public bool DecreaseTime37 = true;
	public bool DecreaseTime38 = true;
	public bool DecreaseTime39 = true;
	public bool DecreaseTime40 = true;
	
	
	
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
	public float gesturetime14 = 0.0f;
	public float gesturetime15= 0.0f;
	public float gesturetime16= 0.0f;
	public float gesturetime17= 0.0f;
	public float gesturetime18= 0.0f;
	public float gesturetime19= 0.0f;
	public float gesturetime20= 0.0f;
	public float gesturetime21= 0.0f;
	public float gesturetime22= 0.0f;
	public float gesturetime23= 0.0f;
	public float gesturetime24= 0.0f;
	public float gesturetime25= 0.0f;
	public float gesturetime26= 0.0f;
	public float gesturetime27= 0.0f;
	public float gesturetime28= 0.0f;
	public float gesturetime29= 0.0f;
	public float gesturetime30= 0.0f;
	public float gesturetime31= 0.0f;
		public float gesturetime32= 0.0f;
		public float gesturetime33= 0.0f;
		public float gesturetime34= 0.0f;
		public float gesturetime35= 0.0f;
		public float gesturetime36= 0.0f;
		public float gesturetime37= 0.0f;
		public float gesturetime38= 0.0f;
		public float gesturetime39= 0.0f;
		public float gesturetime40= 0.0f;
		public float gesturetime41= 0.0f;
		public float gesturetime42= 0.0f;
		public float gesturetime43= 0.0f;
		public float gesturetime44= 0.0f;
		public float gesturetime45= 0.0f;
		public float gesturetime46= 0.0f;
		public float gesturetime47= 0.0f;
		public float gesturetime48= 0.0f;
		public float gesturetime49= 0.0f;
		public float gesturetime50= 0.0f;
		public float gesturetime51= 0.0f;
		public float gesturetime52= 0.0f;
		public float gesturetime53= 0.0f;
		public float gesturetime54= 0.0f;
		public float gesturetime55= 0.0f;
		public float gesturetime56= 0.0f;
		public float gesturetime57= 0.0f;
		public float gesturetime58= 0.0f;
		public float gesturetime59= 0.0f;
		public float gesturetime60= 0.0f;
	
	
	
	public float EndTime = 0.0f;
	public float displaycomplete = 0.0f;
	
	
	//--------------------------------------------------------------------
	
	
	//this statement will call the Initialize unction
	 void Awake(){
		 	scoreIndScript = scoreObject.GetComponent<ScoreIndicator>();	
		
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
	
			
 }
	//------------------------------
	// Use this for initialization
	void Start () {
			PlayerPrefs.SetInt("CurrentScore", 0);
		
			DecreaseTimeHalf= false;
			Decrease41to60 = false;
			
		
			perfTexture.enabled = false;
			missTexture.enabled = false;
			scoreText2.enabled = false;
			dancecompleteBoard.enabled = false;
			applause.audio.enabled = false;
		
		
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("wrongmovegesture",6)==true)  {
			scoreIndScript.MissBad();
					}
		
		DecreaseReady = true;
		DecreaseThree= true;
		DecreaseTwo = true;
		DecreaseOne = true;
		DecreaseGo = true;
		DecreaseDisableReadySetGo = true;
		
		Decrease17to30 = true;
		DecreaseTimeHalf = true;
		Decrease41to60 = true;
		
		
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
		DecreaseTime14 = true;
		DecreaseTime15 = true;
		DecreaseTime16 = true;
	 
		
		DecreaseTime31 = true;
		DecreaseTime32 = true;
		DecreaseTime33 = true;
		DecreaseTime34 = true;
		DecreaseTime35 = true;
		DecreaseTime36 = true;
		DecreaseTime37 = true;
		DecreaseTime38 = true;
		DecreaseTime39 = true;
		DecreaseTime40 = true;
		
		
			//Enabling the Gesture and registering to beckonManager
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
		
	}

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
		
		if(Decrease17to30 ==true){
			gesturetime17 -= Time.deltaTime;
			gesturetime18 -= Time.deltaTime;
			gesturetime19 -= Time.deltaTime;
			gesturetime20 -= Time.deltaTime;
			gesturetime21 -= Time.deltaTime;
			gesturetime22 -= Time.deltaTime;
			gesturetime23 -= Time.deltaTime;
			gesturetime24 -= Time.deltaTime;
			gesturetime25 -= Time.deltaTime;
			gesturetime26 -= Time.deltaTime;
			gesturetime27 -= Time.deltaTime;
			gesturetime28 -= Time.deltaTime;
			gesturetime29 -= Time.deltaTime;
			gesturetime30 -= Time.deltaTime;
		}
		
		
		if(DecreaseTimeHalf == true){
		
			gesturetime31 -= Time.deltaTime;
			gesturetime32 -= Time.deltaTime;
			gesturetime33 -= Time.deltaTime;
			gesturetime34 -= Time.deltaTime;
			gesturetime35 -= Time.deltaTime;
			gesturetime36 -= Time.deltaTime;
			gesturetime37 -= Time.deltaTime;
			gesturetime38 -= Time.deltaTime;
			gesturetime39 -= Time.deltaTime;
			gesturetime40 -= Time.deltaTime;
		}
		
		
		
		if(Decrease41to60 ==true){
			gesturetime41 -= Time.deltaTime;
			gesturetime42 -= Time.deltaTime;
			gesturetime43 -= Time.deltaTime;
			gesturetime44 -= Time.deltaTime;
			gesturetime45 -= Time.deltaTime;
			gesturetime46 -= Time.deltaTime;
			gesturetime47 -= Time.deltaTime;
			gesturetime48 -= Time.deltaTime;
			gesturetime49 -= Time.deltaTime;
			gesturetime50 -= Time.deltaTime;
			gesturetime51 -= Time.deltaTime;
			gesturetime52 -= Time.deltaTime;
			gesturetime53 -= Time.deltaTime;
			gesturetime54 -= Time.deltaTime;
			gesturetime55 -= Time.deltaTime;
			gesturetime56 -= Time.deltaTime;
			gesturetime57 -= Time.deltaTime;
			gesturetime58 -= Time.deltaTime;
			gesturetime59 -= Time.deltaTime;
			gesturetime60 -= Time.deltaTime;
		}
		
		
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
		if(DecreaseTime14 == true){	
		gesturetime14 -= Time.deltaTime;
		}
		if(DecreaseTime15 == true){	
		gesturetime15 -= Time.deltaTime;
		}
		if(DecreaseTime16== true){	
		gesturetime16 -= Time.deltaTime;
		}
		
		/*
		gesturetime17 -= Time.deltaTime;
		gesturetime18 -= Time.deltaTime;
		gesturetime19 -= Time.deltaTime;
		
		gesturetime20 -= Time.deltaTime;
		gesturetime21 -= Time.deltaTime;
		gesturetime22 -= Time.deltaTime;
		gesturetime23 -= Time.deltaTime;
		gesturetime24 -= Time.deltaTime;
		gesturetime25 -= Time.deltaTime;
		gesturetime26 -= Time.deltaTime;
		gesturetime27 -= Time.deltaTime;
		gesturetime28 -= Time.deltaTime;
		gesturetime29 -= Time.deltaTime;
		gesturetime30 -= Time.deltaTime;
		gesturetime31 -= Time.deltaTime;
		gesturetime32 -= Time.deltaTime;
		gesturetime33 -= Time.deltaTime;
		gesturetime34 -= Time.deltaTime;
		gesturetime35 -= Time.deltaTime;
		
			gesturetime36 -= Time.deltaTime;
			gesturetime37 -= Time.deltaTime;
			gesturetime38 -= Time.deltaTime;
			gesturetime39 -= Time.deltaTime;
			gesturetime40 -= Time.deltaTime;
		
			gesturetime41 -= Time.deltaTime;
			gesturetime42 -= Time.deltaTime;
			gesturetime43 -= Time.deltaTime;
			gesturetime44 -= Time.deltaTime;
			gesturetime45 -= Time.deltaTime;
			gesturetime46 -= Time.deltaTime;
			gesturetime47-= Time.deltaTime;
			gesturetime48 -= Time.deltaTime;
			gesturetime49 -= Time.deltaTime;
			gesturetime50 -= Time.deltaTime;
			gesturetime51 -= Time.deltaTime;
			gesturetime52 -= Time.deltaTime;
			gesturetime53 -= Time.deltaTime;
			gesturetime54 -= Time.deltaTime;*/
		
		
		
		displaycomplete -= Time.deltaTime;
		
	
		EndTime -= Time.deltaTime;
		
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
			DecreaseOne = false;
		}
		
		if(Go <=0){
			ReadySetGo.text = "Go!!";
			DecreaseGo =false;
		}
		
		if(DisableReadySetGo <=0){
			ReadySetGo.text = "";
			DecreaseDisableReadySetGo = false;
		}
		
		
			if(gesturetime0 < 0.0f )  {
			//BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
	
		
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
	
				
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_firststep",0)==true)  {// this line will call the gesture and match to the recorded gesture
		 		AddScore();// add the score
		
				scoreIndScript.PerfectGood();
				}
			if((gesturetime0 < -3.50f)&&(gesturetime0 < -5.0f)){
						
				scoreIndScript.MissBad();
				
			}
		
			}//
		

		else if((gesturetime0 < -7.50f) && (gesturetime0 < -9.0f  )) {
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_firststep",0)==true)  {
			scoreIndScript.PerfectGood();
			}
					
		else if((gesturetime0 < -8.50f) && (gesturetime0 < -9.0f  ))  {
				scoreIndScript.MissBad();
				scoreIndScript.HidePerfect();
			}
			
		}
		
		if(gesturetime0 <= -7.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
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
					BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");//this line will enable the first gesture within the time duration
	
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
	
			
			
				
				if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_firststep",2)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 		
					AddScore();
					scoreIndScript.PerfectGood();
					if((gesturetime1 < -6.0f)&&(gesturetime1 < -8.0f)){
					scoreIndScript.MissBad();
						
			}
		
				
				}
			}//
			
				else if((gesturetime1 < -2.0f) && (gesturetime1 < -3.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_firststep",2)==true)  {
					scoreIndScript.PerfectGood();
					AddScore();
				
			}
					
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_firststep",2)==false)  {
					
					scoreIndScript.MissBad();
					
				
			}
			
		}
		
		if(gesturetime1 <= -3.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
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
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
		
			
		
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true)  {
		 		
					AddScore();
				scoreIndScript.PerfectGood();
						if((gesturetime2 < -2.0f)&&(gesturetime2 < -3.0f)){
					scoreIndScript.MissBad();
						MinusScore();
			}
				}
				}//
			
			
		
				else if((gesturetime2 < -1.50f) && (gesturetime2 < -3.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",3)==true)  {
			scoreIndScript.PerfectGood();
					AddScore();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",3)==false)  {
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
				
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
		
			
			//-------------------------------------CALL THE FOURTH GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true)  {
		 		//if the player gesture match with the gesture "leftclick"
				//after a seconds Disable the gesture
					AddScore();
					scoreIndScript.PerfectGood();
					if((gesturetime3 < -1.0f)&&(gesturetime3 < -3.0f)){
				
					scoreIndScript.MissBad();
					
			}
				}
					}
			
	
				else if((gesturetime3 < -2.50f) && (gesturetime3 < -3.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true)  {
					scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==false)  {
				 		scoreIndScript.MissBad();
					MinusScore();
				
			}
			
		}
		
		if(gesturetime3 <= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime3 = false;
				PauseTimer3();
				scoreIndScript.HidePerfect();
			
			}
		
		
		
			//------------------------------------------------------------------------------------------>
		//                   				
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		
		 if(gesturetime4 <= 0.0f) {
							
			
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
			
				
			//-----------------------------------------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==true)  {
		 		//if the player gesture match with the gesture "leftclick"
				//after a seconds Disable the gesture
			AddScore();
					scoreIndScript.PerfectGood();
				
					if((gesturetime4 < -1.0f)&&(gesturetime4 < -2.0f)){
					scoreIndScript.MissBad();
					
					}
			}
				
				}
			
			else if((gesturetime4 <= -7.50f) && (gesturetime4 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==true)  {
					scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",3)==false)  {
			scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime4 <= -3.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
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
				
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==true) 
			{
		 		
				AddScore();
				scoreIndScript.PerfectGood();
					if((gesturetime5 < -1.0f)&&(gesturetime5 < -2.0f)){
					scoreIndScript.MissBad();
					
					}
				}
				}
			
			else if((gesturetime5<= -1.50f) && (gesturetime5 <= -3.50f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==true)  {
					scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==false)  {
					scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime5 <= -3.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime5 = false;
				PauseTimer5();
				scoreIndScript.HidePerfect();
				scoreIndScript.MissBad();
			}
		
		//--------------------------------------------------------===============================================
		
		 if(gesturetime6 <= 0.0f) {
			
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
		
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==true) {
		 		
						AddScore();
						scoreIndScript.PerfectGood();
				
					if((gesturetime6 < -1.0f)&&(gesturetime6 < -3.0f)){
					scoreIndScript.MissBad();
					
					}
				}
				}
			
			else if((gesturetime6<= -2.50f) && (gesturetime6 <= -3.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",3)==true)  {
					scoreIndScript.PerfectGood();
				
			}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",3)==false)  {
				 scoreIndScript.MissBad();
					MinusScore();
				
			}
			
		}
		
		if(gesturetime6 <= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime6 = false;
				PauseTimer6();
			
				scoreIndScript.PerfectGood();
			}
			
			
			///////////-------------------------------------------------
		
		 if(gesturetime7 <= 0.0f){
			
			
				BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
			
				
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true)  {
		 		
					AddScore();
					scoreIndScript.PerfectGood();
				
				
					if((gesturetime7< -2.0f)&&(gesturetime7 < -4.0f)){
					scoreIndScript.MissBad();
					
					}
				}
		}//
			
		
				else if((gesturetime7<= -1.50f) && (gesturetime7 <= -2.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true)  {
						scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==false)  {
				 	 scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime7<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime7 = false;
				PauseTimer7();
				scoreIndScript.HidePerfect();
				 scoreIndScript.MissBad();
			}
		
		
		
		
		
		
		 if(gesturetime8 <= 0.0f){
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
	
			
			
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_firststep",2)==true)  {
		 		
			AddScore();
				scoreIndScript.PerfectGood();
				
					if((gesturetime8 < -1.0f)&&(gesturetime8 < -2.0f)){
					scoreIndScript.MissBad();
					
					}
				}
				}
			
			else if((gesturetime8<= -3.50f) && (gesturetime8 <= -4.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_firststep",2)==true)  {
					scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_firststep",2)==false)  {
					 scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime8<= -5.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime8 = false;
				PauseTimer8();
				scoreIndScript.PerfectGood();
			}
		
		
		
		
		
		 if(gesturetime9 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
			
	
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==true)  {
		 		
			AddScore();
				scoreIndScript.PerfectGood();
				
					if((gesturetime9 < -3.0f)&&(gesturetime9 < -5.0f)){
					scoreIndScript.MissBad();
				
					}
				
				}
				}
			
			
			else if((gesturetime9<= -2.50f) && (gesturetime9 <= -3.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==true)  {
					scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==false)  {
				 		 scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime9<= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime9 = false;
				PauseTimer9();
				scoreIndScript.HideWrong();
				scoreIndScript.PerfectGood();
			}
			
		 if(gesturetime10 <= 0.0f) {
				
		
				
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_handwave");
		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==true)  {
		 		
						AddScore();
						scoreIndScript.PerfectGood();
				
					if((gesturetime10 < -4.0f)&&(gesturetime10 < -7.0f)){
					scoreIndScript.MissBad();
			
					}
				}
				}
				else if((gesturetime10<= -4.50f) && (gesturetime10 <= -6.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==true)  {
					scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==false)  {
				 	 scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime10 <= -10.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime10 = false;
				PauseTimer10();
			 scoreIndScript.MissBad();
			}
				
		
		
		 if(gesturetime11 <= 0.0f) {
				BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupright");
				
		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",4)){
		 		
			AddScore();
					scoreIndScript.PerfectGood();
				
				}
				}
			
					else if((gesturetime11<= -2.50f) && (gesturetime11 <= -4.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",4)==true)  {
				scoreIndScript.PerfectGood();
				
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",4)==false)  {
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
				
			
			
	

			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",2)==true)  {
		 		
			AddScore();
					scoreIndScript.PerfectGood();
				}
				}
			else if((gesturetime12<= -7.50f) && (gesturetime12 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true)  {
				scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==false)  {
				 scoreIndScript.MissBad();
				
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
		
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupright");
		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupright",3)) {
		 		
				AddScore();
			scoreIndScript.PerfectGood();
				}
				}
			
				else if((gesturetime13<= -7.50f) && (gesturetime13 <= -10.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupright",5)==true)  {
				scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupright",5)==false)  {
					 scoreIndScript.MissBad();
			}
			
		}
		
		
		
		
		
		 if(gesturetime14<= 0.0f) {
		
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_stepup_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_handwave");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("kuratsa_getupleft");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupright");
		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupright",3)) {
		 		
				AddScore();
			scoreIndScript.PerfectGood();
				}
				}
			
				else if((gesturetime14<= -3.50f) && (gesturetime14 <= -5.0f  )) {
					 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupright",5)==true)  {
				scoreIndScript.PerfectGood();
				}
					
					if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupright",5)==false)  {
					 scoreIndScript.MissBad();
			}
			
		}
		
		
		
		
			if(gesturetime15 <= 0.0f){
		BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
		BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
		
			
			
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	AddScore();
			}
		}
		
		
			else if((gesturetime15 <= -1.50f) && (gesturetime15 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime15<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime15= false;
				PauseTimer15();
			}
		
		
		
		
		
			if(gesturetime16 <= 0.0f){
		
			Decrease17to30 = true;
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
		}
		
		else if((gesturetime16 <= -1.50f) && (gesturetime16 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime16<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime16= false;
				PauseTimer16();
			
			}
		
			
		
		
			if(gesturetime17 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
				
			
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	AddScore();
			}
		}
		
		else if((gesturetime17 <= -1.50f) && (gesturetime17 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime17<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer17();
			}
		
		
		
		
			if(gesturetime18 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)) {
		 	AddScore();
				}
			}
		
		else if((gesturetime18 <= -1.50f) && (gesturetime18 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime18<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				
				PauseTimer18();
			}
		
		
		if(gesturetime19 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
			
			
			
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	AddScore();
			}
				}
		
		else if((gesturetime19 <= -1.50f) && (gesturetime19 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime19<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer19();
			}
		
		
		if(gesturetime20 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_handwave");
				
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)) {
		 	AddScore();
				}
		}
		
			
		else if((gesturetime20 <= -1.50f) && (gesturetime20 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime20<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				
				PauseTimer20();
			}
		//FEBRUARY _02 _2014
		
		
		
		if(gesturetime21 <= 0.0f){//turnaround
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
			
			
			
		if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	AddScore();
			}
		}
		
			else if((gesturetime21 <= -1.50f) && (gesturetime21 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime21<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				
				PauseTimer21();
			}
		
		
		
		if(gesturetime22 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_handwave");
		
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)) {
		 	AddScore();
				}
		}
		
				else if((gesturetime22 <= -1.50f) && (gesturetime22 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime22<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer22();
			}
		
		
		
		
		
		
		
		//start of clockwise step
		//gesture9 = clockwise
		//use step for handwave
			if(gesturetime23 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
			
			
			
		if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	AddScore();
			}
		}
		
		else if((gesturetime23 <= -1.50f) && (gesturetime23 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime23<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				
				PauseTimer23();
			}
		
		
		
		
			if(gesturetime24 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
			
		}
		
				else if((gesturetime24 <= -1.50f) && (gesturetime24 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime24<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				
				PauseTimer24();
			}
		
		
		
			if(gesturetime25 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
		}
			else if((gesturetime25 <= -1.50f) && (gesturetime25 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime25<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer25();
			}
		
		
		
		
		
		
		
		
			if(gesturetime26 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
		}
			else if((gesturetime26 <= -1.50f) && (gesturetime26 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime26<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				
				PauseTimer26();
			}
		
		
		
			if(gesturetime27 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
			
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
		}
			else if((gesturetime27 <= -1.50f) && (gesturetime27 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime27<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				
				PauseTimer27();
			}
		
		
			if(gesturetime28 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
			
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
		}
			else if((gesturetime28 <= -1.50f) && (gesturetime28 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime28<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer28();
			}
		
		
		
		if(gesturetime29 <= 0.0f){//turn arround..kain muna
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
			
			
			
	if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	AddScore();
			}
			}
			else if((gesturetime29 <= -1.50f) && (gesturetime29 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime29<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
		
				PauseTimer29();
			}
		
		
			if(gesturetime30 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupleft");
			
		
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)) {
		 	AddScore();
				}
		}
			else if((gesturetime30 <= -1.50f) && (gesturetime30 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime30<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTimeHalf = true;
				Decrease17to30 = false;
				PauseTimer30();
			}
		
		
		
		
			
			if(gesturetime31 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupleft_mir");
			
		
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft_mir",5)) {
		 	AddScore();
				}
			}
			else if((gesturetime31 <= -1.50f) && (gesturetime31 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft_mir",5)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft_mir",5)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime31<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime31= false;
				PauseTimer31();
			}
		
		
				if(gesturetime32 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupleft");
			
			
		
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)) {
		 	AddScore();
			}
			}
			else if((gesturetime32 <= -1.50f) && (gesturetime32 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime32<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime32= false;
				PauseTimer32();
			}
		
		
		
				if(gesturetime33 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupleft_mir");
			
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft_mir",5)) {
		 	AddScore();
				}
			}
			else if((gesturetime33 <= -1.50f) && (gesturetime33 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft_mir",5)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft_mir",5)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime33<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime33= false;
				PauseTimer33();
			}
		
				if(gesturetime34 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupleft");
			
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)) {
		 	AddScore();
				}
		}
			else if((gesturetime34 <= -1.50f) && (gesturetime34 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime34<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime34= false;
				PauseTimer34();
			}
		
		
		
		
		
		
				if(gesturetime35 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupleft");
			
		
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)) {
		 	AddScore();
				}
		
				}
			else if((gesturetime35 <= -1.50f) && (gesturetime35 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime35<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime35= false;
				PauseTimer35();
			}
		
		

		
				if(gesturetime36 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupleft");
			
		
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)) {
		 	AddScore();
				}
			}
			else if((gesturetime36 <= -1.50f) && (gesturetime36 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft",4)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		if(gesturetime36<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime36= false;
				PauseTimer36();
			}
		
		
			if(gesturetime37 <= 0.0f){
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_getupleft_mir");
	
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft_mir",5)) {
		 	AddScore();
				}
				}
			else if((gesturetime37 <= -1.50f) && (gesturetime37 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft_mir",5)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_getupleft_mir",5)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime37<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime37= false;
				PauseTimer37();
			}
		
		
		////------------------------
		
		
		
		//handwave 1:25
			if(gesturetime38 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
					}
			else if((gesturetime38 <= -1.50f) && (gesturetime38 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime38<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime38= false;
				PauseTimer38();
			}
		
		
		
			if(gesturetime39 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_stepup");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_stepup_mir");
			
			
			
		if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	AddScore();
			}
					}
			else if((gesturetime39 <= -1.50f) && (gesturetime39 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime39<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime39 = false;
				PauseTimer39();
			}
		
		
		
			if(gesturetime40 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
			Decrease41to60 = true;
			DecreaseTimeHalf = false;
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true) {
		 	AddScore();
				}
				}
			else if((gesturetime40 <= -1.50f) && (gesturetime40 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime40<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime40 = false;
				PauseTimer40();
			}
		
		
		
		/////////////////////////
		
			if(gesturetime41 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
			
			}
			else if((gesturetime41 <= -1.50f) && (gesturetime41 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime41<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				
				PauseTimer41();
			}


		
			if(gesturetime42 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
			}
			else if((gesturetime42 <= -1.50f) && (gesturetime42 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime42<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				
				PauseTimer42();
			}

		
			if(gesturetime43 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
			}
			else if((gesturetime43 <= -1.50f) && (gesturetime43 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime43<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				
				PauseTimer43();
			}

		
			if(gesturetime44 <= 0.0f){//
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
			}
			else if((gesturetime44 <= -1.50f) && (gesturetime44 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime44<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer44();
			}

		
		
			if(gesturetime45 <= 0.0f){//
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
		BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
			
			
			
				
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	
				AddScore();
			
			}
			}
			else if((gesturetime45 <= -1.50f) && (gesturetime45 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime45<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer45();
			}

		
			
		
			if(gesturetime46 <= 0.0f){//
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
			}
			else if((gesturetime46 <= -1.50f) && (gesturetime46 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime46<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer46();
			}

			
		
			if(gesturetime47 <= 0.0f){//
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
		
		
				
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	
				AddScore();
			
			}
			
			}
			else if((gesturetime47 <= -1.50f) && (gesturetime47 <= -2.0f  )) {
			 if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true)) {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime47<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer47();
			}

		
			
		
			if(gesturetime48 <= 0.0f){//
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
				
			}
			else if((gesturetime48 <= -1.50f) && (gesturetime48 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true) {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime48<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer48();
			}

		
			if(gesturetime49 <= 0.0f){//
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
		
			
				
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	
				AddScore();
			
			}
			}
			else if((gesturetime49 <= -1.50f) && (gesturetime49 <= -2.0f  )) {
			 if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
			
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime49<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer49();
			}
			

			if(gesturetime50 <= 0.0f){//
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
			
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
			}
			else if((gesturetime50 <= -1.50f) && (gesturetime50 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==true) {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)==false)  {
				 missTexture.enabled = true;	
				 perfTexture.enabled =false;
				
			}
			}
		
		
		if(gesturetime50<= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer50();
			}

			///////////////////////////////////////FEBRUARY 05, 2014----
		
			if(gesturetime51 <= 0.0f){//
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
		BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
		
			
			
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	
				AddScore();
			
			}
			
			else {
		
			}
		}
		
			
		
			if(gesturetime52 <= 0.0f){//
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_handwave",3)) {
		 	AddScore();
				}
			
			else {
		
			}
		}
		
				if(gesturetime53<= 0.0f){//
			
					BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup");
		BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("kuratsa_stepup_mir");
				
			
			
			
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup",0)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("kuratsa_stepup_mir",1)==true))  {
		 	
				AddScore();
			
			}
			else {
		
			}
		}
		
			
			if(gesturetime54<= 0.0f){//
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_handwave");
		
		
	
		}
		
			
		
		
		
		if(displaycomplete<=0.0f){
			DisplayComplete();
			
		}

		
		
		if(EndTime <=0){
			GameOver();
		}
		
		
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
	
		void PauseTimer14(){
		gesturetime14 = 0.0f;
	}
	
		void PauseTimer15(){
		gesturetime15 = 0.0f;
	}
	
		void PauseTimer16(){
		gesturetime16 = 0.0f;
	}
	
	
	void PauseTimer17(){
		gesturetime17 = 0.0f;
	}
	
	void PauseTimer18(){
		gesturetime18 = 0.0f;
	}
	
	void PauseTimer19(){
		gesturetime19 = 0.0f;
	}
	
	void PauseTimer20(){
		gesturetime20 = 0.0f;
	}
	
	void PauseTimer21(){
		gesturetime21 = 0.0f;
	}
	
	void PauseTimer22(){
		gesturetime22 = 0.0f;
	}
	
		void PauseTimer23(){
		gesturetime23 = 0.0f;
	}
	
		void PauseTimer24(){
		gesturetime24 = 0.0f;
	}
	
	
		void PauseTimer25(){
		gesturetime25 = 0.0f;
	}
	
		void PauseTimer26(){
		gesturetime26 = 0.0f;
	}
	
		void PauseTimer27(){
		gesturetime27 = 0.0f;
	}
	
		void PauseTimer28(){
		gesturetime28 = 0.0f;
	}
	
		void PauseTimer29(){
		gesturetime29= 0.0f;
	}
	
		void PauseTimer30(){
		gesturetime30= 0.0f;
	}
	
	
		void PauseTimer31(){
		gesturetime31= 0.0f;
	}
	
		void PauseTimer32(){
		gesturetime32= 0.0f;
	}
	
		void PauseTimer33(){
		gesturetime33= 0.0f;
	}
	
		void PauseTimer34(){
		gesturetime34= 0.0f;
	}
	
		void PauseTimer35(){
		gesturetime35= 0.0f;
	}
	
		void PauseTimer36(){
		gesturetime36 = 0.0f;
	}
	
		void PauseTimer37(){
		gesturetime37= 0.0f;
	}
	
		void PauseTimer38(){
		gesturetime38 = 0.0f;
	}
	
		void PauseTimer39(){
		gesturetime39= 0.0f;
	}
	
		void PauseTimer40(){
		gesturetime40= 0.0f;
	}

		void PauseTimer41(){
		gesturetime41= 0.0f;
	}

		void PauseTimer42(){
		gesturetime42= 0.0f;
	}

		void PauseTimer43(){
		gesturetime43= 0.0f;
	}

		void PauseTimer44(){
		gesturetime44= 0.0f;
	}

		void PauseTimer45(){
		gesturetime45= 0.0f;
	}

		void PauseTimer46(){
		gesturetime46= 0.0f;
	}

		void PauseTimer47(){
		gesturetime47= 0.0f;
	}

		void PauseTimer48(){
		gesturetime48= 0.0f;
	}

		void PauseTimer49(){
		gesturetime49= 0.0f;
	}

		void PauseTimer50(){
		gesturetime50= 0.0f;
	}
	
	
	
	//displaying Gestures
	void OnGUI () {
		GUI.skin.box = gui1;
		
			if(showBox){
		//GUILayout.BeginArea ( new Rect( Screen.width/2-Screen.width / 8, 10, Screen.width / 4, Screen.height /2 ) );
		//GUI.Label (Rect (25, 25, 100, 30), "Score:" + score.ToString()); 
        GUILayout.Box ("Score: ");
     //   GUILayout.EndArea ();
		}
		
		
		                  
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
	











