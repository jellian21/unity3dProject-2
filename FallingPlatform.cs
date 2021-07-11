using UnityEngine;
using System.Collections;

public class FallingPlatform : MonoBehaviour {
	
	
	
	private Rigidbody2D rd2d;
	public float fallDelay;
	public static int theScore;

	void Awake(){
		
		rd2d = GetComponent<Rigidbody2D> ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter2D(Collision2D collide){
		
		
		if (collide.collider.tag=="Player") {
			
			StartCoroutine (Fall ());

			
		}
		if (collide.gameObject.tag == "Enemy") {
			theScore+=1;
			Destroy(collide.gameObject);
		}
	}
	

	IEnumerator Fall(){

		yield return new WaitForSeconds (fallDelay);
		rd2d.isKinematic = false;
		yield return new WaitForSeconds (1);
		Destroy (this.gameObject);
		yield return 0;
	}



}
