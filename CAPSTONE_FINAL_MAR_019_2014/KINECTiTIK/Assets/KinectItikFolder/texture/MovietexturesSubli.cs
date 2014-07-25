using UnityEngine;
using System.Collections;

public class MovietexturesSubli : MonoBehaviour {

	  public MovieTexture movTexture;
    void Start() {
        renderer.material.mainTexture = movTexture;
		
        movTexture.Play();
		
		audio.Play();
	
    }
}