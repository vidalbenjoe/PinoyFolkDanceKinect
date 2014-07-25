
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




public class GestureScriptSubli : MonoBehaviour {
	
	public AudioSource applause;
	public string loadLevel = "";
	public GUIText scoreText;
	public GUIText scoreText2;
	public int score = 0;

	public GUIStyle gui1;

	public float PerfTextTimer = 0.0f;
	public float MissTextTimer = 0.0f;
	public GUITexture dancecompleteBoard;
	
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
	
	
	public GUITexture perfTexture;
	public GUITexture missTexture;
	
	
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
	//start of gesture window
	GameObject gestures1;
    Texture2D gesTexture1;
	GUITexture guitexture1;
	
	GameObject gestures2;
    Texture2D gesTexture2;
	GUITexture guitexture2;
	
	GameObject gestures3;
    Texture2D gesTexture3;
	GUITexture guitexture3;
	
	GameObject gestures4;
    Texture2D gesTexture4;
	GUITexture guitexture4;
	
	GameObject gestures5;
    Texture2D gesTexture5;
	GUITexture guitexture5;
	
	GameObject gestures6;
    Texture2D gesTexture6;
	GUITexture guitexture6;
	
	GameObject gestures7;
    Texture2D gesTexture7;
	GUITexture guitexture7;
	
	
	GameObject gestures8;
    Texture2D gesTexture8;
	GUITexture guitexture8;
	
	GameObject gestures9;
    Texture2D gesTexture9;
	GUITexture guitexture9;
	
	GameObject gestures10;
    Texture2D gesTexture10;
	GUITexture guitexture10;
	
	GameObject gestures11;
    Texture2D gesTexture11;
	GUITexture guitexture11;
	
	GameObject gestures12;
    Texture2D gesTexture12;
	GUITexture guitexture12;
	
	GameObject gestures13;
    Texture2D gesTexture13;
	GUITexture guitexture13;
	
	GameObject gestures14;
    Texture2D gesTexture14;
	GUITexture guitexture14;
	
	GameObject gestures15;
    Texture2D gesTexture15;
	GUITexture guitexture15;
	
	GameObject gestures16;
    Texture2D gesTexture16;
	GUITexture guitexture16;
	
	GameObject gestures17;
    Texture2D gesTexture17;
	GUITexture guitexture17;
	
	
	//----End of Gestures Window
	
	//this statement will call the Initialize unction
	 void Awake(){
       
			perfTexture.enabled = false;
			missTexture.enabled = false;
		 Initialize();
		BeckonSessionConfiguration sessionConf = new BeckonSessionConfiguration();
			
		
 }
	//----------------------------
	// Use this for initialization
	
	void Start () {
			PlayerPrefs.SetInt("CurrentScore", 0);
		
			perfTexture.enabled = false;
			missTexture.enabled = false;
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
		    gestures1.transform.localScale = Vector3.zero;
        	gestures1.AddComponent(guitexture1.GetType());
        	gestures1.guiTexture.texture = gesTexture1;
        	gestures1.guiTexture.pixelInset = new Rect(1180, 410, 140, 130);
		
		
			gestures2.transform.localScale = Vector3.zero;
        	gestures2.AddComponent(guitexture2.GetType());
        	gestures2.guiTexture.texture = gesTexture2;
        	gestures2.guiTexture.pixelInset = new Rect(1190, 300, 120, 110);
		
		    gestures3.transform.localScale = Vector3.zero;
        	gestures3.AddComponent(guitexture3.GetType());
        	gestures3.guiTexture.texture = gesTexture3;
        	gestures3.guiTexture.pixelInset = new Rect(1190, 190, 120, 110);
		
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
		
				}
	
	//set the texture for every gesture
	
	
	private void Initialize(){
		
        gestures1 = new GameObject();
        gesTexture1 = (Texture2D)Resources.Load("s1");
        guitexture1 = new GUITexture();
		
		
		gestures2 = new GameObject();
        gesTexture2 = (Texture2D)Resources.Load("s2");
        guitexture2 = new GUITexture();
 
		
		gestures3 = new GameObject();
        gesTexture3 = (Texture2D)Resources.Load("s3");
        guitexture3 = new GUITexture();
		
		gestures4 = new GameObject();
        gesTexture4 = (Texture2D)Resources.Load("s4");
        guitexture4 = new GUITexture();
		
		gestures5 = new GameObject();
        gesTexture5 = (Texture2D)Resources.Load("s5");
        guitexture5 = new GUITexture();
		
		gestures6 = new GameObject();
        gesTexture6 = (Texture2D)Resources.Load("s6");
        guitexture6 = new GUITexture();
 
		
		gestures7 = new GameObject();
        gesTexture7 = (Texture2D)Resources.Load("s7");
        guitexture7 = new GUITexture();
		
		gestures8 = new GameObject();
        gesTexture8 = (Texture2D)Resources.Load("s8");
        guitexture8 = new GUITexture();
		
		gestures9 = new GameObject();
        gesTexture9 = (Texture2D)Resources.Load("s9");
        guitexture9 = new GUITexture();
		
		gestures10 = new GameObject();
        gesTexture10 = (Texture2D)Resources.Load("s10");
        guitexture10 = new GUITexture();
		
		gestures11 = new GameObject();
        gesTexture11 = (Texture2D)Resources.Load("s11");
        guitexture11 = new GUITexture();
		
		gestures12 = new GameObject();
        gesTexture12 = (Texture2D)Resources.Load("s12");
        guitexture12 = new GUITexture();
		
		gestures13 = new GameObject();
        gesTexture13 = (Texture2D)Resources.Load("s13");
        guitexture13 = new GUITexture();
		
		gestures14 = new GameObject();
        gesTexture14 = (Texture2D)Resources.Load("s14");
        guitexture14 = new GUITexture();
		
		gestures15 = new GameObject();
        gesTexture15 = (Texture2D)Resources.Load("s15");
        guitexture15 = new GUITexture();
		
		gestures16= new GameObject();
        gesTexture16 = (Texture2D)Resources.Load("s16");
        guitexture16 = new GUITexture();
		
		gestures17 = new GameObject();
        gesTexture17= (Texture2D)Resources.Load("s17");
        guitexture17 = new GUITexture();
		
		
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
		
					perfTexture.enabled =true;
				}
			}//
		
			else if((gesturetime0 <= -8.50f) && (gesturetime0 <= -10.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime0 <= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime0 = false;
				PauseTimer0();
				
			}
		
		
		 if(gesturetime1 <= 0.0f){
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_secondtstep");
			
			
		
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture2;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture3;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture4;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_secondstep",1)==true) {
		 		AddScore();
			
		}
			}//
		
			else if((gesturetime1 <= -1.50f) && (gesturetime1 <= -2.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime1 <= -2.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime1 = false;
				PauseTimer1();
				
			}
		
		
		
		 if(gesturetime2 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_thirdstep");
	
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture3;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture4;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture5;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==true) {
		 		
			AddScore();
	
							
		}
			}//
		
			else if((gesturetime2 <= -1.50f) && (gesturetime2 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime2 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			
				PauseTimer2();
				
			}
		
		
		
		 if(gesturetime3 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitiksubli_fourthstep");
			
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture4;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture5;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture6;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)){
		 		
			AddScore();
									
		}
			}//
		
			else if((gesturetime3 <= -1.50f) && (gesturetime3 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime3 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
				DecreaseTime3 = false;
				PauseTimer3();	
			}
		
		
		
		 if(gesturetime4 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture5;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture6;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture7;
			
			
				
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)){
		 		
			AddScore();
											
		}
			}//
		
			else if((gesturetime4 <= -1.50f) && (gesturetime4 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime4 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime4 = false;
				PauseTimer4();
				
			}
		
		
		
		
		
		
		 if(gesturetime5 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fifthstep");

				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture6;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture7;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture8;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==true)){
		 		
			AddScore();
				}
			}//
		
			else if((gesturetime5 <= -1.50f) && (gesturetime5 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime5 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime5 = false;
				PauseTimer5();
				
			}
		
		
		 if(gesturetime6 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fifthstep");

				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture7;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture8;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture9;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==true)){
		 		
			AddScore();
				}
			}//
		
			else if((gesturetime6 <= -1.50f) && (gesturetime6 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime6 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime6 = false;
				PauseTimer6();
				
			}
		
		
			
		 if(gesturetime7 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep");
		
			
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture8;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture9;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture10;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true) {
		 		
			AddScore();
					}
			}//
		
			else if((gesturetime7 <= -1.50f) && (gesturetime7 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime7 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime7 = false;
				PauseTimer7();
				
			}
		
		
			
		 if(gesturetime8 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep");
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture9;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture10;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture11;
			
			
				//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true) {
		 		
			AddScore();
					}
			}//
		
			else if((gesturetime8 <= -1.50f) && (gesturetime8 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime8 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime8 = false;
				PauseTimer8();
				
			}
		
		
		
		
		 if(gesturetime9 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep_mir");
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture10;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture11;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture12;
			
			
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true) {
		 		
			AddScore();
				}
			}//
		
			else if((gesturetime9 <= -1.50f) && (gesturetime9 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime9 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime9 = false;
				PauseTimer9();
				
			}
		
		
		if(gesturetime10 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep_mir");
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture11;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture6;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture7;
			
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true) {
		 		
			AddScore();
				}
			}//
		
			else if((gesturetime10 <= -1.50f) && (gesturetime10 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime10 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime10 = false;
				PauseTimer10();
				
			}
		
		if(gesturetime11 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fifthstep");
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fifthstep_mir");
		
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture6;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture7;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture4;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fifthstep_mir",6)==true)) {
		 		
			AddScore();
						}
			}//
		
			else if((gesturetime11 <= -1.50f) && (gesturetime11 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime11 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime11 = false;
				PauseTimer11();
				
			}
		
		
		
				
		if(gesturetime12 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fifthstep");
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fifthstep_mir");
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture7;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture4;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture5;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fifthstep",5)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fifthstep",6)==true)) {
		 		
			AddScore();
					}
			}//
		
			else if((gesturetime12 <= -1.50f) && (gesturetime12 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fifthstep",5)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime12 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime12 = false;
				PauseTimer12();
				
			}
				
				
				
		if(gesturetime13 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep_mir");
		
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture4;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture5;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture3;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep_mir",4)==true)){
		 		
			AddScore();
					}
			}//
		
			else if((gesturetime13 <= -1.50f) && (gesturetime13 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime13 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime13 = false;
				PauseTimer13();
				
			}
				
		
		
		
			if(gesturetime14 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep_mir");
		
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture5;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture3;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture1;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
				if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep_mir",4)==true)){
		 		
			AddScore();
					}
			}//
		
			else if((gesturetime14 <= -1.50f) && (gesturetime14 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime14 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime14 = false;
				PauseTimer14();
				
			}
				
		
		
		if(gesturetime15 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_thirdstep");
			
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture3;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture1;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture2;
			
			
			
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_thirdstep",2)==true) {
		 		
			AddScore();
			}
			}//
		
			else if((gesturetime15 <= -1.50f) && (gesturetime15 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_thirdstep",2)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_thirdstep",2)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime15 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime15 = false;
				PauseTimer15();
				
			}
		
		
			if(gesturetime16 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_firststep");
			
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture1;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture2;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture8;
			
			
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_firststep",0)==true)  {
		 	
			AddScore();
		}
			}//
		
			else if((gesturetime16 <= -1.50f) && (gesturetime16 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_firststep",0)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_firststep",0)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime16 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime16 = false;
				PauseTimer16();
				
			}
		
		
		
		
		
			if(gesturetime17 <= 0.0f){
		
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_secondstep");
		
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture2;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture8;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture9;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_secondstep",1)==true) {
		 		
			AddScore();
				
		}
			}//
		
			else if((gesturetime17 <= -1.50f) && (gesturetime17 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_secondstep",1)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_secondstep",1)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime17 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime17 = false;
				PauseTimer17();
				
			}
		
		
		
			if(gesturetime18 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep_mir");
			
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture8;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture9;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture10;
			
			
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true) ){
		 		
			AddScore();
				}
			}//
		
			else if((gesturetime18 <= -1.50f) && (gesturetime18 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime18 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime18 = false;
				PauseTimer18();
				
			}
		
			
			if(gesturetime19 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep_mir");
			
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture10;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture11;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture12;
			
			
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true) ){
		 		
			AddScore();
					}
			}//
		
			else if((gesturetime19 <= -1.50f) && (gesturetime19 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime19 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime19 = false;
				PauseTimer19();
				
			}
		
		
		
		if(gesturetime20 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_sixthstep_mir");
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture11;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture12;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture13;
			
			
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep_mir",8)==true) ){
		 		
			AddScore();
						}
			}//
		
			else if((gesturetime20 <= -1.50f) && (gesturetime20 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_sixthstep",7)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime20 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime20 = false;
				PauseTimer20();
				
			}
		
				
				
		
		if(gesturetime21 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep_mir");
			
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture12;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture13;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture17;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",4)==true))  {
		 		
			AddScore();
				}
			}//
		
			else if((gesturetime21 <= -1.50f) && (gesturetime21 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
			
		}
		
		if(gesturetime21 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime21 = false;
				PauseTimer21();
				
			}
		
		
		
		
		
		
		
		if(gesturetime22 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_fourthstep_mir");
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture13;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture17;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture16;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",4)==true))  {
		 		
			AddScore();
		
				}
			}//
		
			else if((gesturetime22 <= -1.50f) && (gesturetime22 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_fourthstep",3)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
		}
		
		
		
		if(gesturetime22 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime22 = false;
				PauseTimer22();
				
			}
		
		
			
		if(gesturetime23 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_seventhstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_seventhstep_mir");
			
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture17;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture16;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture3;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep_mir",10)==true)){
		 		
			AddScore();
			}
			}//
		
			else if((gesturetime23 <= -1.50f) && (gesturetime23 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
		}
		
		
		
		if(gesturetime23 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime23 = false;
				PauseTimer23();
				
			}
				
				
		if(gesturetime24 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_seventhstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("subli_seventhstep_mir");
			
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture16;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture3;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
			if((BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==true) || (BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep_mir",10)==true)){
		 		
			AddScore();
				}
			}//
		
			else if((gesturetime24 <= -1.50f) && (gesturetime24 <= -4.0f  )) {
			 if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==true)  {
				perfTexture.enabled =true;
				missTexture.enabled = false;
				
			}
					
				if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("subli_seventhstep",9)==false)  {
				 missTexture.enabled = true;	
				perfTexture.enabled =false;
				
			}
		}
		
		
		
		if(gesturetime24 <= -4.0f){//after -10 millisec..  set gesturetime0 to 0 then stop deltaTime using DecreaseTime0 = false;
			DecreaseTime24 = false;
				PauseTimer24();
				
			}
				
				
		
		
		if(gesturetime25 <= 0.0f){
		
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture3;
			
			
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
        _tempScore += 16;
        PlayerPrefs.SetInt("CurrentScore", _tempScore);
    }
	
	
	
		  void MinusScore()
    {
        int _tempScore = PlayerPrefs.GetInt("CurrentScore");
        _tempScore -= 2;
        PlayerPrefs.SetInt("CurrentScore", _tempScore);
    }
	
	
	  void belowZero()
    {
        int _tempScore = PlayerPrefs.GetInt("CurrentScore");
		if(_tempScore <= 0){
        _tempScore = 0;
        PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
    }
	
		  void scoreCondition()
    {
        int _tempScore = PlayerPrefs.GetInt("CurrentScore");
		//int _tempScore = 0;
		
		if(_tempScore <= 0)  {
		_tempScore = 0;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
		if(_tempScore <= 100)  {
		_tempScore = 100;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
		
       	if((_tempScore == 0) && (_tempScore <= 10))  {
		_tempScore = 10;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
		
		if((_tempScore >= 11) && (_tempScore <= 20))  {
		_tempScore = 20;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
		if((_tempScore >= 21) && (_tempScore <= 30))  {
		_tempScore = 30;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
		if((_tempScore >= 31) && (_tempScore <= 40))  {
		_tempScore = 40;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
		
			if((_tempScore >= 41) && (_tempScore <= 50))  {
		_tempScore = 50;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
		
		if((_tempScore >= 51) && (_tempScore <= 60))  {
		_tempScore = 60;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
			if((_tempScore >= 61) && (_tempScore <= 70))  {
		_tempScore = 70;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
			if((_tempScore >= 71) && (_tempScore <= 80))  {
		_tempScore = 80;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
			if((_tempScore >= 81) && (_tempScore <= 90))  {
		_tempScore = 90;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
			if((_tempScore >= 91) && (_tempScore <= 100))  {
		_tempScore = 100;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		}
		
    }
	
	void DisplayComplete(){
		scoreText.text = "";
		dancecompleteBoard.enabled = true;
		scoreText2.enabled =true;
		scoreCondition();
		scoreText2.text = "" + PlayerPrefs.GetInt("CurrentScore")+"%";
		applause.audio.enabled = true;
		
	}
	
	
	void perfFuctionTimerElse(){
	perfTexture.enabled = false;
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
	void OnGUI () {
		GUI.skin.box = gui1;
		
		GUILayout.BeginArea ( new Rect( Screen.width/2-Screen.width / 8, 10, Screen.width / 4, Screen.height /2 ) );
		//GUI.Label (Rect (25, 25, 100, 30), "Score:" + score.ToString()); 
        GUILayout.Box ("Score: " );
        GUILayout.EndArea ();

                   
 	
	}
	

}







