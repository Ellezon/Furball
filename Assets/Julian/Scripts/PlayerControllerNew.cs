using UnityEngine;
using System.Collections;

public class PlayerControllerNew : MonoBehaviour {

	public float maxSpeed = 6f;
	public float jumpForce = 1000f;
	public Transform groundCheck;
	public LayerMask whatIsGround;
	public float verticalSpeed = 20;
	[HideInInspector]
	public bool lookingRight = true;
	bool doubleJump = false;
	public GameObject Boost;

	private Animator cloudanim;
	public GameObject Cloud;


	private Rigidbody2D rb2d;
	private Animator anim;
	private bool isGrounded = false;

	// for wrap around
	private Renderer[] renderers;
	private bool isWrappingX = false;
	private bool isWrappingY = false;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		//cloudanim = GetComponent<Animator>();

		Cloud = GameObject.Find("Cloud");
		//cloudanim = GameObject.Find("Cloud(Clone)").GetComponent<Animator>();
	
		// for wrap around
		renderers = GetComponentsInChildren<Renderer>();
	}


	void OnCollisionEnter2D(Collision2D collision2D) {

		if (collision2D.relativeVelocity.magnitude > 20){
			Boost = Instantiate(Resources.Load("Prefabs/Cloud"), transform.position, transform.rotation) as GameObject;
			//	cloudanim.Play("cloud");	

		}
	}
		
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Jump") && (isGrounded || !doubleJump))
		{
			rb2d.AddForce(new Vector2(0,jumpForce));

			if (!doubleJump && !isGrounded)
			{
				doubleJump = true;
				Boost = Instantiate(Resources.Load("Prefabs/Cloud"), transform.position, transform.rotation) as GameObject;
				//	cloudanim.Play("cloud");		
			}
		}


		if (Input.GetButtonDown("Vertical") && !isGrounded)
		{
			rb2d.AddForce(new Vector2(0,-jumpForce));
			Boost = Instantiate(Resources.Load("Prefabs/Cloud"), transform.position, transform.rotation) as GameObject;
			//cloudanim.Play("cloud");
		}

	}
		
	void FixedUpdate()
	{
		if (isGrounded) 
			doubleJump = false;


		float hor = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (hor));

		rb2d.velocity = new Vector2 (hor * maxSpeed, rb2d.velocity.y);

		isGrounded = Physics2D.OverlapCircle (groundCheck.position, 0.15F, whatIsGround);

		anim.SetBool ("IsGrounded", isGrounded);

		if ((hor > 0 && !lookingRight)||(hor < 0 && lookingRight))
			Flip ();

		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		// for wrap around
		ScreenWrap();
	}

	void ScreenWrap()
	{
		Vector2 newPosition = transform.position;
		bool isVisible = CheckRenderers ();

		if (isVisible) 
		{
			isWrappingX = false;
			isWrappingY = false;
			Debug.Log ("is visible"+newPosition);
			return;
		}

		if (isWrappingX && isWrappingY) 
		{			
			Debug.Log ("is wraPPING X AND Y");
			Debug.Log (newPosition);
			return;
		}

		//if (newPosition.x > 1 || newPosition.x < 0)
		if (newPosition.x > 10.5 || newPosition.x < -9.5)
		{
			Debug.Log ("wrap X1"+newPosition);
			newPosition.x = -newPosition.x;
			isWrappingX = true;
			Debug.Log ("wrap X2"+newPosition);
		}

/*		if (newPosition.y > 1 || newPosition.y < 0) 
		{
			newPosition.y = -newPosition.y;
			isWrappingY = true;
			Debug.Log ("wrap Y"+newPosition);
		}
*/
		transform.position = newPosition;
		Debug.Log("position"+transform.position);
	}

	public void Flip()
	{
		lookingRight = !lookingRight;
		Vector3 myScale = transform.localScale;
		myScale.x *= -1;
		transform.localScale = myScale;
	}

	// for wrap around
	bool CheckRenderers()
	{
		foreach (Renderer renderer in renderers)
		{
			if (renderer.isVisible) 
			{
				return true;
			}
		}

		return false;
	}
}
	
