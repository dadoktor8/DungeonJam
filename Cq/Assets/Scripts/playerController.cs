 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {


	public float speed; 
	private  Rigidbody2D rb;
	private Vector2 moveVelocity;
	public KeyCode left; 
	public KeyCode right; 
	public KeyCode up; 
	public KeyCode down; 

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();




	}

	void Update()
	{

		/*if (Input.GetKey (left)) {
			rb.velocity = new Vector2 (-speed, rb.velocity.y);

		} else if (Input.GetKey (right)) {
			rb.velocity = new Vector2 (speed, rb.velocity.y); 

		} else 
		{
			rb.velocity = new Vector2 (0, rb.velocity.y); 

		}
		if (Input.GetKey (up)) {
			rb.velocity = new Vector2 (rb.velocity.x, -speed); 
		} else if (Input.GetKey (down)) {
			rb.velocity = new Vector2 (rb.velocity.x, speed); 
		} else
		{
			rb.velocity = new Vector2 (rb.velocity.x, 0); 
		}*/

		Vector2 moveInput = new Vector3 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		moveVelocity = moveInput.normalized * speed; 
			

	}

	void FixedUpdate(){
		rb.MovePosition (rb.position + moveVelocity * Time.fixedDeltaTime); 
		
	}

}
