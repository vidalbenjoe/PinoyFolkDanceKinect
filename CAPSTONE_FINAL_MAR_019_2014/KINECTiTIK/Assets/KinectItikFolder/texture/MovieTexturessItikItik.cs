using UnityEngine;
using System.Collections;

public class MovieTexturessItikItik : MonoBehaviour {

	  public MovieTexture movTexture;
    void Start() {
        renderer.material.mainTexture = movTexture;
        movTexture.Play();
		audio.Play();
    }
}