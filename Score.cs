using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;

	void Update()
	{
		
		scoreText.text = "Score: " + FallingPlatform.theScore;
		
	}
}
