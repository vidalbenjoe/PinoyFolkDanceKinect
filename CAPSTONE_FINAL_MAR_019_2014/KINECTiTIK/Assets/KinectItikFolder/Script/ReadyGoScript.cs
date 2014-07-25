using UnityEngine;
using System.Collections;

public class ReadyGoScript : MonoBehaviour {
public GUIText readyGo;
	// Use this for initialization
	void Start()
{
    StartCoroutine( readySetGoTimer( 2 ) );
}
 
private IEnumerator readySetGoTimer( float wait )
{
	readyGo.text = "Ready!";
   	 	yield return new WaitForSeconds(wait);
    readyGo.text = "1";
    	yield return new WaitForSeconds(wait);
  	readyGo.text = "2";
    	yield return new WaitForSeconds(wait);
    readyGo.text = "3";
		yield return new WaitForSeconds(wait);
    readyGo.text = "Go...";
	
	
	
	}
	
}
