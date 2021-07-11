using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public float moveSpeed;
	Vector3 theScale;
	
	void Awake () {
		theScale = transform.localScale;
	}
	
	void Update() {
		transform.Translate (new Vector3(moveSpeed,0,0) * Time.deltaTime);
	}
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Ground"){
			moveSpeed *= -1;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}
	

}
