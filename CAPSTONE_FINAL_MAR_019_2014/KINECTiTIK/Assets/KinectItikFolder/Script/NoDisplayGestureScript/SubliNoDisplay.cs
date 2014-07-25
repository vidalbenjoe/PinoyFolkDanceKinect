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

public class SubliNoDisplay : MonoBehaviour {
	public GameObject scoreObject;
	private ScoreIndicator scoreIndScript; 
	
	public bool showBox = true;
	
	public AudioSource applause;
	public string loadLevel = "";
	public GUIText scoreText;
	public GUIText scoreText2;
	public int score = 0;

	public GUIStyle gui1;

	public GUITexture dancecompleteBoard;
	
	
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
	public GUIText ReadySetGo;
	

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
	public bool DecreaseTime14 = true;
	public bool DecreaseTime15 = true;
	public bool DecreaseTime16 = true;
	public bool DecreaseTime17 = true;
	public bool DecreaseTime18 = true;
	public bool DecreaseTime19 = true;
	public bool DecreaseTime20 = true;
	public bool DecreaseTime21 = true;
	public bool DecreaseTime22 = true;
	public bool DecreaseTime23 = true;
	public bool DecreaseTime24 = true;
	public bool DecreaseTime25 = true;
	
	//-----------------------------------
	
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
	public float gesturetime15 = 0.0f;
	public float gesturetime16 = 0.0f;
	public float gesturetime17 = 0.0f;
	public float gesturetime18 = 0.0f;
	public float gesturetime19 = 0.0f;
	public float gesturetime20 = 0.0f;
	public float gesturetime21 = 0.0f;
	public float gesturetime22 = 0.0f;
	public float gesturetime23 = 0.0f;
	public float gesturetime24 = 0.0f;
	public float gesturetime25 = 0.0f;
	
	
	public float EndTime = 0.0f;
	
		public float displaycomplete = 0.0f;
	//--------------------------------------------------------------------
	
	
	
	//----End of Gestures Window
	
	//this statement will call the Initialize unction
	 void Awake(){
       
		scoreIndScript = scoreObject.GetComponent<ScoreIndicator>();
		
 }
	//------------------------------
	// Use this for initialization
	
	void Start () {
			PlayerPrefs.SetInt("CurrentScore", 0);
		
	
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
		DecreaseTime14 = true;
		DecreaseTime15 = true;
		DecreaseTime16 = true;
		DecreaseTime17 = true;
		DecreaseTime18 = true;
		DecreaseTime19 = true;
		DecreaseTime20 = true;
		DecreaseTime21 = true;
		DecreaseTime22 = true;
		DecreaseTime23 = true;
		DecreaseTime24 = true;
		DecreaseTime25 = true;
		
		
		
		
			//from 0-16 seconds hide the gestures
		
	/*
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_fourthstep_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_fifthstep_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_sixthstep_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_seventhstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_seventhstep_mir");
		
		*/
				BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_seventhstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_seventhstep_mir");
		
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_fifthstep_mir");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_seventhstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("subli_seventhstep_mir");
				}
	
	//set the texture for every gesture
	
	
	
	
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
		
		
		if(DecreaseTime14 == true){
		gesturetime14 -= Time.deltaTime;
			}
		if(DecreaseTime15 == true){
		gesturetime15 -= Time.deltaTime;
				}
		if(DecreaseTime16 == true){
		gesturetime16 -= Time.deltaTime;
		}
		if(DecreaseTime17 == true){
		gesturetime17 -= Time.deltaTime;
		}
		if(DecreaseTime18 == true){
		gesturetime18 -= Time.deltaTime;
		}
		if(DecreaseTime19 == true){
		gesturetime19 -= Time.deltaTime;
		}
		if(DecreaseTime20 == true){
		gesturetime20 -= Time.deltaTime;
		}
		if(DecreaseTime21 == true){
		gesturetime21 -= Time.deltaTime;
		}
		if(DecreaseTime22 == true){
		gesturetime22 -= Time.deltaTime;
		}
		if(DecreaseTime23 == true){
		gesturetime23 -= Time.deltaTime;
		}
		if(DecreaseTime24 == true){
		gesturetime24 -= Time.deltaTime;
		}
		if(DecreaseTime25 == true){
		gesturetime25 -= Time.deltaTime;
		}
		//<---------------------------------timer para sa first gesture
		displaycomplete -= Time.deltaTime;
		
		EndTime -= Time.deltaTime;
		
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
		
		
			if(gesturetime0 <= 0) {
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_secondstep");
		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
		 	
						AddScore();
		
						scoreIndScript.PerfectGood();
				
				}
			
				if((gesturetime0 < -4.0f)&&(gesturetime0 < -7.0f)){
						
				scoreIndScript.MissBad();
				MinusScore();
			}
			}//
		
			else if((gesturetime0 <= -8.50f) && (gesturetime0 <= -10.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime0 <= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime0 = false;
				PauseTimer0();
				scoreIndScript.MissBad();
				
			}
		
		
		 if(gesturetime1 <= 0.0f){
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_secondtstep");
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_secondstep",1)==true) {
		 		AddScore();
			
						scoreIndScript.PerfectGood();
		}
				if((gesturetime1 < -4.0f)&&(gesturetime1 < -7.0f)){
						
				scoreIndScript.MissBad();
				MinusScore();
			}
			
			}//
		
			else if((gesturetime1 <= -1.50f) && (gesturetime1 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
			
						scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime1 <= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime1 = false;
				PauseTimer1();
				
			}
		
		
		
		 if(gesturetime2 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_thirdstep");
	
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==true) {
		 		
			AddScore();
				scoreIndScript.PerfectGood();
				
							
		}
				if((gesturetime2 < -1.0f)&&(gesturetime2 < -3.0f)){
						scoreIndScript.MissBad();
				MinusScore();
			}
		}//
		
			else if((gesturetime2 <= -1.50f) && (gesturetime2 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
							scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
						scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime2 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer2();
				
			}
		
		
		
		 if(gesturetime3 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitiksubli_fourthstep");
			
				
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)){
		 		
			AddScore();
				scoreIndScript.PerfectGood();					
		}
			}//
		
			else if((gesturetime3 <= -1.50f) && (gesturetime3 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
			scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime3 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime3 = false;
				PauseTimer3();	
			}
		
		
		
		 if(gesturetime4 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			
				
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)){
		 		
			AddScore();
					scoreIndScript.PerfectGood();							
		}
			
				if((gesturetime4 < -3.0f)&&(gesturetime4 < -5.0f)){
						scoreIndScript.MissBad();
				MinusScore();
			}
			}//
		
			else if((gesturetime4 <= -1.50f) && (gesturetime4 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				scoreIndScript.PerfectGood();
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime4 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime4 = false;
				PauseTimer4();
				
			}
		
		
		
		
		
		
		 if(gesturetime5 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fifthstep");

			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==true)){
		 			scoreIndScript.PerfectGood();					
			AddScore();
				}
			}//
		
			else if((gesturetime5 <= -1.50f) && (gesturetime5 <= -3.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				scoreIndScript.PerfectGood();					
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime5 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime5 = false;
				PauseTimer5();
				
			}
		
		
		 if(gesturetime6 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fifthstep");

			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==true)){
		 			scoreIndScript.PerfectGood();		
			AddScore();
				}
			}//
		
			else if((gesturetime6 <= -1.50f) && (gesturetime6 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
					scoreIndScript.PerfectGood();		
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime6 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime6 = false;
				PauseTimer6();
				
			}
		
		
			
		 if(gesturetime7 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep");
		
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true) {
		 		scoreIndScript.PerfectGood();		
			AddScore();
					}
			}//
		
			else if((gesturetime7 <= -1.50f) && (gesturetime7 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true)  {
			scoreIndScript.PerfectGood();		
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==false)  {
					scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime7 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime7 = false;
				PauseTimer7();
				
			}
		
		
			
		 if(gesturetime8 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep");
				
			
			
				//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true) {
		 			scoreIndScript.PerfectGood();		
			AddScore();
				
					}
			
				if((gesturetime8 < -3.0f)&&(gesturetime8 < -6.0f)){
						scoreIndScript.MissBad();
			}
			}//
		
			else if((gesturetime8 <= -1.50f) && (gesturetime8 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true)  {
					scoreIndScript.PerfectGood();		
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==false)  {
				scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime8 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime8 = false;
				PauseTimer8();
				
			}
		
		
		
		
		 if(gesturetime9 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep_mir");
			
			
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true) {
		 			scoreIndScript.PerfectGood();		
			AddScore();
				}
				if((gesturetime9 < -5.0f)&&(gesturetime8 < -8.0f)){
						scoreIndScript.MissBad();
			}
			}//
		
			else if((gesturetime9 <= -1.50f) && (gesturetime9 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true)  {
				scoreIndScript.PerfectGood();		
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==false)  {
			scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime9 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime9 = false;
				PauseTimer9();
					scoreIndScript.MissBad();
			}
		
		
		if(gesturetime10 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep_mir");
				
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true) {
		 			scoreIndScript.PerfectGood();		
			AddScore();
				}
			}//
		
			else if((gesturetime10 <= -1.50f) && (gesturetime10 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true)  {
				scoreIndScript.PerfectGood();		
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==false)  {
			scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime10 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime10 = false;
				PauseTimer10();
				
			}
		
		if(gesturetime11 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fifthstep");
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fifthstep_mir");
		
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fifthstep_mir",6)==true)) {
		 			scoreIndScript.PerfectGood();	
			AddScore();
						}
			
				if((gesturetime11 < -2.0f)&&(gesturetime11 < -3.0f)){
						scoreIndScript.MissBad();
			}
			
			}//
		
			else if((gesturetime11 <= -1.50f) && (gesturetime11 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==true)  {
					scoreIndScript.PerfectGood();	
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==false)  {
					scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime11 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime11 = false;
				PauseTimer11();
				
			}
		
		
		
				
		if(gesturetime12 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fifthstep");
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fifthstep_mir");
			
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fifthstep",5)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fifthstep",6)==true)) {
		 			scoreIndScript.PerfectGood();	
			AddScore();
					}
			
				if((gesturetime12 < -2.0f)&&(gesturetime12 < -5.0f)){
						scoreIndScript.MissBad();
			}
			
			}//
		
			else if((gesturetime12 <= -1.50f) && (gesturetime12 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==true)  {
					scoreIndScript.PerfectGood();	
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==false)  {
				scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime12 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime12 = false;
				PauseTimer12();
				scoreIndScript.MissBad();
			}
				
				
				
		if(gesturetime13 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep_mir");
		
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep_mir",4)==true)){
		 			scoreIndScript.PerfectGood();	
			AddScore();
					}
			if((gesturetime13< -4.0f)&&(gesturetime13 < -6.0f)){
						scoreIndScript.MissBad();
			}
			
			}//
		
			else if((gesturetime13 <= -1.50f) && (gesturetime13 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
					scoreIndScript.PerfectGood();	
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==false)  {
				scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime13 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime13 = false;
				PauseTimer13();
				
			}
				
		
		
		
			if(gesturetime14 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep_mir");
		
			//-------------------------------------CALL THE FIRST GESTURE----------------------
				if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep_mir",4)==true)){
		 		scoreIndScript.PerfectGood();		
			AddScore();
					}
			}//
		
			else if((gesturetime14 <= -1.50f) && (gesturetime14 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true)  {
				scoreIndScript.PerfectGood();	
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==false)  {
				scoreIndScript.MissBad();
				
				
			}
			
		}
		
		if(gesturetime14 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime14 = false;
				PauseTimer14();
						scoreIndScript.MissBad();
			}
				
		
		
		if(gesturetime15 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_thirdstep");
			
			
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_thirdstep",2)==true) {
		 			scoreIndScript.PerfectGood();		
			AddScore();
			}
			}//
		
			else if((gesturetime15 <= -1.50f) && (gesturetime15 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_thirdstep",2)==true)  {
				scoreIndScript.PerfectGood();		
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_thirdstep",2)==false)  {
				scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime15 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime15 = false;
				PauseTimer15();
				
			}
		
		
			if(gesturetime16 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_firststep");
			
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_firststep",0)==true)  {
		 		scoreIndScript.PerfectGood();		
				
			AddScore();
		}
			}//
		
			else if((gesturetime16 <= -1.50f) && (gesturetime16 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_firststep",0)==true)  {
				scoreIndScript.PerfectGood();		
				
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_firststep",0)==false)  {
				scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime16 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime16 = false;
				PauseTimer16();
					scoreIndScript.MissBad();
			}
		
		
		
		
		
			if(gesturetime17 <= 0.0f){
		
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_secondstep");
		
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_secondstep",1)==true) {
		 			scoreIndScript.PerfectGood();		
			AddScore();
				
		}
				if((gesturetime17< -4.0f)&&(gesturetime17 < -7.0f)){
						scoreIndScript.MissBad();
			}
			}//
		
			else if((gesturetime17 <= -1.50f) && (gesturetime17 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_secondstep",1)==true)  {
				scoreIndScript.PerfectGood();		
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_secondstep",1)==false)  {
					scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime17 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime17 = false;
				PauseTimer17();
				
			}
		
		
		
			if(gesturetime18 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep_mir");
		
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true) ){
		 			scoreIndScript.PerfectGood();		
			AddScore();
					if((gesturetime18< -4.0f)&&(gesturetime18 < -7.0f)){
						scoreIndScript.MissBad();
			}
				}
			}//
		
			else if((gesturetime18 <= -1.50f) && (gesturetime18 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true)  {
					scoreIndScript.PerfectGood();	
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==false)  {
				scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime18 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime18 = false;
				PauseTimer18();
					scoreIndScript.MissBad();
			}
		
			
			if(gesturetime19 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep_mir");
			
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true) ){
		 				scoreIndScript.PerfectGood();	
			AddScore();
					}
			}//
		
			else if((gesturetime19 <= -1.50f) && (gesturetime19 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true)  {
					scoreIndScript.PerfectGood();	
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==false)  {
							scoreIndScript.MissBad();
				MinusScore();
				
			}
			
		}
		
		if(gesturetime19 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime19 = false;
				PauseTimer19();
					scoreIndScript.MissBad();
			}
		
		
		
		if(gesturetime20 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep_mir");
			
			
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true) ){
		 	scoreIndScript.PerfectGood();			
			AddScore();
						}
			
				if((gesturetime20< -4.0f)&&(gesturetime20 < -7.0f)){
						scoreIndScript.MissBad();
			}
			}//
		
			else if((gesturetime20 <= -1.50f) && (gesturetime20 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true)  {
					scoreIndScript.PerfectGood();	
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==false)  {
					scoreIndScript.MissBad();
				
			}
			
		}
		
		if(gesturetime20 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime20 = false;
				PauseTimer20();
					scoreIndScript.MissBad();
			}
		
				
				
		
		if(gesturetime21 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep_mir");
			
		
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",4)==true))  {
		 		scoreIndScript.PerfectGood();			
			AddScore();
				
				}
			
			if((gesturetime21< -4.0f)&&(gesturetime21 < -7.0f)){
						scoreIndScript.MissBad();
			}
			}//
		
			else if((gesturetime21 <= -1.50f) && (gesturetime21 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true)  {
					scoreIndScript.PerfectGood();	
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==false)  {
					scoreIndScript.MissBad();
				MinusScore();
			}
			
		}
		
		if(gesturetime21 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime21 = false;
				PauseTimer21();
					scoreIndScript.MissBad();
			}
		
		
		
		
		
		
		
		if(gesturetime22 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep_mir");
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",4)==true))  {
		 			scoreIndScript.PerfectGood();	
			AddScore();
		
				}
				if((gesturetime22< -4.0f)&&(gesturetime22 < -7.0f)){
						scoreIndScript.MissBad();
			}
			}//
		
			else if((gesturetime22 <= -1.50f) && (gesturetime22 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true)  {
				scoreIndScript.PerfectGood();	
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==false)  {
				scoreIndScript.MissBad();MinusScore();
			}
		}
		
		
		
		if(gesturetime22 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime22 = false;
				PauseTimer22();
					scoreIndScript.MissBad();
			}
		
		
			
		if(gesturetime23 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_seventhstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_seventhstep_mir");
		
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep_mir",10)==true)){
		 			scoreIndScript.PerfectGood();	
			AddScore();
			}
			
			
			}//
		
			else if((gesturetime23 <= -1.50f) && (gesturetime23 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==true)  {
					scoreIndScript.PerfectGood();	
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==false)  {
			scoreIndScript.MissBad();MinusScore();
				
			}
		}
		
		
		
		if(gesturetime23 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime23 = false;
				PauseTimer23();
					scoreIndScript.MissBad();
			}
				
				
		if(gesturetime24 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_seventhstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_seventhstep_mir");
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep_mir",10)==true)){
		 		scoreIndScript.PerfectGood();	
					
			AddScore();
				}
					if((gesturetime24< -3.0f)&&(gesturetime24 < -5.0f)){
						scoreIndScript.MissBad();
			}
			}//
		
			else if((gesturetime24 <= -1.50f) && (gesturetime24 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==true)  {
				scoreIndScript.PerfectGood();	
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==false)  {
					scoreIndScript.MissBad();MinusScore();
				
			}
		}
		
		
		
		if(gesturetime24 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime24 = false;
				PauseTimer24();
					scoreIndScript.MissBad();
			}
				
		if(gesturetime25 <= 0.0f){
		
		
			
		}
		
		
			if(displaycomplete<=0.0f){
			
			DisplayComplete();
		}
		
		if(EndTime <=0 ){
			GameOver();
		}
		
		
		
		
		
	}
	 void AddScore()
    {
        int _tempScore = PlayerPrefs.GetInt("CurrentScore");
        _tempScore += 7;
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
		gesturetime5 = 0.0f;
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
		gesturetime14= 0.0f;
	}
	
	void PauseTimer15(){
		gesturetime15 = 0.0f;
	}
	
	void PauseTimer16(){
		gesturetime16= 0.0f;
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
	
	
	//displaying Gestures
	//displaying Gestures
	void OnGUI () {
		GUI.skin.box = gui1;
		
		GUILayout.BeginArea ( new Rect( Screen.width/2-Screen.width / 8, 10, Screen.width / 4, Screen.height /2 ) );
		////GUI.Label (Rect (25, 25, 100, 30), "Score:" + score.ToString()); 
        
		if(showBox){
		
		GUILayout.Box ("Score: ");
		}
        GUILayout.EndArea ();

                   
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
	











