using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

	public float force = 300.5f;
	public Rigidbody2D bola;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(this.gameObject.CompareTag("Ball")){
			if (Input.GetKeyDown (KeyCode.Space)) {
				bola.AddForce (new Vector2 (0, force * Time.deltaTime), ForceMode2D.Impulse);
				return;
			}
		}
	}
}
