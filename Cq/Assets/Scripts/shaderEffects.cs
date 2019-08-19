using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaderEffects : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		transform.localScale += new Vector3 (0.01f, 0.01f, 0.01f); 
		if (transform.localScale.x > 2f) 
		{
			transform.localScale = new Vector3 (0.01f, 0.01f, 0.01f); 	

		}



	}
}
