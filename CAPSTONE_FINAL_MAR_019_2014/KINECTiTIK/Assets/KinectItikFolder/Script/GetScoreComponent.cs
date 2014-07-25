using UnityEngine;
using System.Collections;

public class GetScoreComponent : MonoBehaviour {

	public GUIText scoreText;
    public GUIText highScoreText;
	
	  void CheckHighscore()
    {
        int _score = PlayerPrefs.GetInt("CurrentScore", 0);
        int _highscore = PlayerPrefs.GetInt("HighScore", 0);
        if (_score > _highscore)
            PlayerPrefs.SetInt("HighScore", _score);
    }
	

	// Use this for initialization
	void Start () {
 	
        CheckHighscore();
		
		scoreText.text = "" + PlayerPrefs.GetInt("CurrentScore", 0);
        highScoreText.text = "" + PlayerPrefs.GetInt("HighScore", 0);
		
		
	}
	

	
		}
	


