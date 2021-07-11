using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class AnimationController : MonoBehaviour {

	public int speed;
	public bool jump=true;
	public float jumpHeight;
	public bool leftDir;
	public bool	rightDir;
	public bool	idle;
	public Animator anim;
	public static int PlayerLife=3;

	void Awake () 
	{
		anim = GetComponent<Animator>();
	}

	void Start () 
	{
			//	score = 0;

	}
	
		/*public void UpdateScore()
		{


				scoreText.text="Score:"+score;

		}*/
	void Update () 
	{
				//UpdateScore();
			//	score += scoreValue;
		float move=Input.GetAxis("Horizontal");

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
		{
			GetComponent<Rigidbody2D>().transform.position+=Vector3.left*speed*Time.deltaTime;
			leftDir=true;
			rightDir=false;
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
		{
			GetComponent<Rigidbody2D>().transform.position+=Vector3.right*speed*Time.deltaTime;
			leftDir=false;
			rightDir=true;
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (jump==true){
				GetComponent<Rigidbody2D>().velocity = new Vector2 (0, jumpHeight);
				jump = false;
			}
			
		}  

	if (move == 0)
		{
			
			idle=true;
		}
		else if(move!=0)
		{
			idle=false;
		}
		anim.SetBool ("walkleft_1", leftDir);
		anim.SetBool ("walkright_2", rightDir);
		anim.SetBool ("idle_1",idle);

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ground"||col.gameObject.tag == "Wall") {
			
			jump = true;
			
		}

		if (col.gameObject.tag == "Enemy") {
			PlayerLife-=1;

			if (PlayerLife<=0)
			{
				//SceneManager.GetActiveScene();
				SceneManager.LoadScene(0);
				PlayerLife=3;
				FallingPlatform.theScore = 0;
			}
		}
	}
}

	


