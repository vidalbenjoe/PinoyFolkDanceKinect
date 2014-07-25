using UnityEngine;
using System.Collections;

public class MovieTextureskuratsa : MonoBehaviour {

	  public MovieTexture movTexture;
    void Start() {
        renderer.material.mainTexture = movTexture;
        movTexture.Play();
		audio.Play();
		
		Shader unlit = Shader.Find("Unlit/Texture");
		renderer.material.shader = unlit;
		
		
    }
}