using UnityEngine;
using System.Collections;
using OmekFramework.Common.Main;
using OmekFramework.Beckon.Main;

public class ItikItikTestGestureCalibrate : MonoBehaviour {

	// Use this for initialization
	public string LoadLevel = "";


	
	GameObject gestures1;
    Texture2D gesTexture1;
	GUITexture guitexture1;
	
	GameObject gestures2;
    Texture2D gesTexture2;
	GUITexture guitexture2;
	
	public GUITexture goodTexture;
	public GUITexture nowfollowthisgesture;
	public GUITexture perfTexture;
	public GUITexture readyTexture;
	
	
	public GUITexture TutSensorImage;
	public GUITexture TutPlayerRadar;
	public GUITexture TutGesturetoFollow;

	
	public float textBlahBlah = 0.0f;//when the text is done --> display the TutSensorImage
	public float displayRadarTut = 0.0f;
	public float displayGesturetoFollowTut = 0.0f;
	public float disableAllTutTexture = 0.0f;
		
	
	
	public float timeb4start;
	public float readyNowTime;
	public float starttimer;
	public float tutorialTimerStart;
	
	
	
	 void Awake(){
		
        Initialize();
		
		
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("lefthand");
		BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("righthand");
		
		goodTexture.enabled = false;
		nowfollowthisgesture.enabled = false;
		readyTexture.enabled = false;
		perfTexture.enabled = false;
		
		
		TutSensorImage.enabled = false;
		TutPlayerRadar.enabled = false;
		TutGesturetoFollow.enabled =false;
		
 }
	
	void Start () {
		PlayerPrefs.SetInt("CurrentScore", 0);
		
		    gestures1.transform.localScale = Vector3.zero;
        	gestures1.AddComponent(guitexture1.GetType());
        	gestures1.guiTexture.texture = gesTexture1;
        	gestures1.guiTexture.pixelInset = new Rect(1180, 410, 140, 130);
		
		
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("lefthand");
			BeckonManager.BeckonInstance.Gestures.DisableSDKGesture("righthand");
		
		goodTexture.enabled = false;
		nowfollowthisgesture.enabled = false;
		readyTexture.enabled = false;
		perfTexture.enabled = false;
		
		TutSensorImage.enabled = false;
		TutPlayerRadar.enabled = false;
		TutGesturetoFollow.enabled =false;
	}
	
	private void Initialize(){
		
        gestures1 = new GameObject();
        gesTexture1 = (Texture2D)Resources.Load("flyGesture");
        guitexture1 = new GUITexture();
		
		gestures2 = new GameObject();
        gesTexture2 = (Texture2D)Resources.Load("standGesture");
        guitexture2 = new GUITexture();
	}
	
	
	
	// Update is called once per frame
	void Update () {
		tutorialTimerStart -= Time.deltaTime;
		textBlahBlah -= Time.deltaTime;
		displayRadarTut -= Time.deltaTime;
		displayGesturetoFollowTut -= Time.deltaTime;
		disableAllTutTexture -= Time.deltaTime;
		
		if(textBlahBlah <=0.0f){
			TutSensorImage.enabled = true;
			
		}
		
		if(displayRadarTut <=0.0f){
			TutPlayerRadar.enabled = true;
			TutSensorImage.enabled = false;
			
		}
		
		if(displayGesturetoFollowTut <=0.0f){
			TutGesturetoFollow.enabled = true;
			TutPlayerRadar.enabled = false;
			TutSensorImage.enabled = false;
		}
		
		if(disableAllTutTexture <=0){
				TutGesturetoFollow.enabled = false;
			TutPlayerRadar.enabled = false;
			TutSensorImage.enabled = false;
		}
		
	
		
			if(tutorialTimerStart <=0.0f){
			BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("righthand");
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("righthand",0)==true)  {
				gestures1.AddComponent(guitexture1.GetType());
				gestures1.guiTexture.texture = gesTexture2;
				
				BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("lefthand");
				goodTexture.enabled = true;
				countdownTimeb4();
				
		 
		}
		}	
		
		
		
	if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("lefthand",1)==true){
			
			perfTexture.enabled = true;
			goodTexture.enabled = false;
			readyTexture.enabled = true;
			startgameTimer();
		}
		
		
		
	}
	
	void countdownTimeb4(){
			nowfollowthisgesture.enabled = true;
			timeb4start -= Time.deltaTime;
		
		if(timeb4start <=0.0f){
			gestures1.AddComponent(guitexture1.GetType());
			gestures1.guiTexture.texture = gesTexture2;
		
			goodTexture.enabled = false;
			startgameTimer();
			}
	}
	
	void startgameTimer(){
	starttimer -= Time.deltaTime;
		
		if(starttimer  <=0.0f){
			 startGame();
		}
		perfTexture.enabled = true;
		//readyTexture.enabled = true;
			nowfollowthisgesture.enabled = false;
	}
	
	
	
	void startGame(){
		Application.LoadLevel(LoadLevel);
		
	}
	
	
	
				//readyTexture.enabled = true;
		
	
	
}
