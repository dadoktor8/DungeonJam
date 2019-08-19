using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript : MonoBehaviour {
	public cameraShake shaker; 
	public float x; 
	public float y; 
	public void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.collider.tag == "Player") 
		{
			Debug.Log ("Collision"); 
			StartCoroutine (shaker.Shake (0.15f, 0.4f)); 
			  
		


	}
}
}
