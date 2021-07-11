using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour {

	public Text lifeText;



	void Update()
	{

		lifeText.text = "Lives: " + AnimationController.PlayerLife;

	}
}
