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

using UnityEngine;
using System.Collections;

using System.Runtime.InteropServices;
using System.IO;
using OmekFramework.Common.Main;
using OmekFramework.Beckon.Main;
using OmekFramework.Common.BasicTypes;
using OmekFramework.Beckon.Data;
using OmekFramework.Common.GeneralUtils;



public class DuplicateGestureScript : MonoBehaviour {
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
	

	//----End of Gestures Window
	
	//this statement will call the Initialize unction
	

	
	 void Awake(){
		Initialize();
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
        gesTexture1 = (Texture2D)Resources.Load("flyGesture");
        guitexture1 = new GUITexture();
		
		
		gestures2 = new GameObject();
        gesTexture2 = (Texture2D)Resources.Load("standGesture");
        guitexture2 = new GUITexture();
 
		
		gestures3 = new GameObject();
        gesTexture3 = (Texture2D)Resources.Load("clockwise");
        guitexture3 = new GUITexture();
		
		gestures4 = new GameObject();
        gesTexture4 = (Texture2D)Resources.Load("swingUp_1");
        guitexture4 = new GUITexture();
		
		gestures5 = new GameObject();
        gesTexture5 = (Texture2D)Resources.Load("swingUp_2");
        guitexture5 = new GUITexture();
		
		gestures6 = new GameObject();
        gesTexture6 = (Texture2D)Resources.Load("duckGesture");
        guitexture6 = new GUITexture();
		
		gestures7 = new GameObject();
        gesTexture7 = (Texture2D)Resources.Load("clockwise");
        guitexture7 = new GUITexture();
		
		gestures8 = new GameObject();
        gesTexture8 = (Texture2D)Resources.Load("standGesture");
        guitexture8 = new GUITexture();
		
		gestures9 = new GameObject();
        gesTexture9 = (Texture2D)Resources.Load("flyGesture");
        guitexture9 = new GUITexture();
		
		gestures10 = new GameObject();
        gesTexture10 = (Texture2D)Resources.Load("clockwise");
        guitexture10 = new GUITexture();
		
		
		gestures11 = new GameObject();
        gesTexture11 = (Texture2D)Resources.Load("slideLeft");
        guitexture11 = new GUITexture();
		
		
		gestures12 = new GameObject();
        gesTexture12 = (Texture2D)Resources.Load("slideRight");
        guitexture12 = new GUITexture();
		
		
		
		gestures13 = new GameObject();
        gesTexture13 = (Texture2D)Resources.Load("clockwise");
        guitexture13 = new GUITexture();
		
		
		gestures14 = new GameObject();
        gesTexture14 = (Texture2D)Resources.Load("standGestures");
        guitexture14 = new GUITexture();
		
		perfTexture.enabled = false;
		missTexture.enabled = false;
    }
	
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
		
		//gesture firsttep
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firststep",0)==true)  {
		 	AddScore();
			missTexture.enabled = false;
			perfTexture.enabled = true;
				}
			else 
			{
			missTexture.enabled = true;
			perfFuctionTimerElse();
			}
		
		//gesture 2nd step
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)==true) {
		 		
			AddScore();
					perfTexture.enabled = true;
			missTexture.enabled = false;
				}
		
			else {
			missTexture.enabled = true;
			perfFuctionTimerElse();
			}
		//gesture third step
		
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_thirdstep",2)) {
		 		
			AddScore();
					perfTexture.enabled = true;
					
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
		
			//
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_fourthstep",3)==true)  {
		 		
			AddScore();
					perfTexture.enabled = true;
		
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
			
				}
			
			else {
		
			perfFuctionTimerElse();
			}
		
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_slideright",7)){
		 		
			AddScore();
					perfTexture.enabled = true;
				
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
		
		
		//GESTURE EIGHT(8)
		if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_slideleft",8)==true)  {
		 		
			AddScore();
					perfTexture.enabled = true;
					MissTextTimer -= Time.deltaTime;
					missTexture.enabled = false;
				
				}
			
			else {
			missTexture.enabled = true;	
			perfFuctionTimerElse();
			}
		
		//<--------------------------------- switching timer para sa first gesture------------------
		
	
	
			if(gesturetime0 <= 0.0f)  {
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
		
			
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
		
				
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture2;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture3;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture4;
			
			}
		
			
		
		
		//------------------------------------------------------------------------------------------>
		//                   				- THIRD GESTURE -
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		
		 if(gesturetime2 == 0.0f){
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			
			
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture3;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture4;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture5;
			
		
		
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
			
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture4;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture3;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture2;
			
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
			
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture5;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture7;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture2;
			
		
			}
		
		
				//------------------------------------------------------------------------------------------>
		//                   			
		//				THE GESTURE MUST FOLLOW PROPERLY WITHIN THE GIVEN TIME
		//------------------------------------------------------------------------------------------>
		
		
		
			 if(gesturetime5 <= 0.0f){
		
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
		
			
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture7;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture8;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture1;
			
	
		
			}
		
		
		 if(gesturetime6 <= 0.0f){
			
		//	BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_firststep");
			//.BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_thirdstep");
		
			
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture2;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture1;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture1;
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
		
			}
		
		
		 if(gesturetime7 <= 0.0f){
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_seventhstep");
			
			gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture1;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture1;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture3;
			
		
			}
		
		
		 if(gesturetime8 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firststep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_secondstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_thirdstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fourthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_fifthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_sixthstep");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_seventhstep");
			
			
			gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture1;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture3;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture11;
			
		
			}
		
		
		 if(gesturetime9 <= 0.0f){
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
		
			
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture3;
			
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture11;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture12;
			
	
			}
		
		 if(gesturetime10 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_slideleft");
		
			
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture11;
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture12;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture3;
			
		
			}
		
		
		 if(gesturetime11 <= 0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_slideright");
	
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture12;
			
				gestures2.AddComponent(guitexture1.GetType());
				gestures2.guiTexture.texture = gesTexture3;
			
				gestures3.AddComponent(guitexture1.GetType());
				gestures3.guiTexture.texture = gesTexture2;
			
		
			}
		
		
		 if(gesturetime12 <= 0.0f){

			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_fourthstep");
			
			
			gestures1.AddComponent(guitexture1.GetType());
			
			gestures1.AddComponent(guitexture1.GetType());
			gestures1.guiTexture.texture = gesTexture3;
			
			gestures2.AddComponent(guitexture1.GetType());
			gestures2.guiTexture.texture = gesTexture2;
			
				//gestures3.AddComponent(guitexture1.GetType());
				//gestures3.guiTexture.texture = gesTexture2;
			
			
		
			}
		
		
			 if(gesturetime13 <= 0.0f){
			//BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("itikitik_firststep");
		//	BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_secondstep");
			
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_thirdstep");
		
			
		
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture2;
			
			
			//-------------------------------------CALL THE FIRST GESTURE----------------------
		
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
	











