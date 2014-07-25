using UnityEngine;
using System.Collections;
using OmekFramework.Common.Main;
using OmekFramework.Beckon.Main;

public class SubliTestGesture : MonoBehaviour {

	// Use this for initialization
	public string LoadLevel = "";

	
	GameObject gestures1;
    Texture2D gesTexture1;
	GUITexture guitexture1;
	
	public GUITexture goodTexture;
	public GUITexture readyTexture;
	
	
	public float timeb4start;
		public float readyNowTime;
	 void Awake(){
        Initialize();
		goodTexture.enabled = false;
			readyTexture.enabled = false;
		
 }
	
	void Start () {
		PlayerPrefs.SetInt("CurrentScore", 0);
		
		    gestures1.transform.localScale = Vector3.zero;
        	gestures1.AddComponent(guitexture1.GetType());
        	gestures1.guiTexture.texture = gesTexture1;
        	gestures1.guiTexture.pixelInset = new Rect(1180, 410, 140, 130);
		
		
		BeckonManager.BeckonInstance.Gestures.EnableSDKGesture("itikitik_firstclick");
		
		goodTexture.enabled = false;
		readyTexture.enabled = false;
	}
	
	private void Initialize(){
		
        gestures1 = new GameObject();
        gesTexture1 = (Texture2D)Resources.Load("flyGesture");
        guitexture1 = new GUITexture();
	}
	
	
	
	// Update is called once per frame
	void Update () {
		
	
			if(BeckonManager.BeckonInstance.Gestures.IsGestureActive("itikitik_firstclick",0))  {
			// Application.LoadLevel(LoadLevel);
			timeb4start -= Time.deltaTime;
			readyNowTime -= Time.deltaTime;
				goodTexture.enabled = true;
			
			if(timeb4start <=0){
				
				Application.LoadLevel(LoadLevel);
			}
			
			if(readyNowTime <=0){
				readyTexture.enabled = true;
			}
			
			
			Debug.Log("Gesture Correct");
			//Pop Up Gui Text
			//make a skip button but not in this line
		}
		
	}
}
