using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	
	public Animator anim;

	void Awake (){
		
		anim = GetComponent<Animator> ();
	}


	
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {	
			Destroy (col.gameObject);
			//yield return new WaitForSeconds(1);
			SceneManager.LoadScene (2);
			AnimationController.PlayerLife=3;
			FallingPlatform.theScore = 0;
		} 
		
	}
}
