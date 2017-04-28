using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

//	void OnCollisionEnter2D(Collision2D o){
//		if(o.gameObject.CompareTag("Plank")){
//			Destroy (o.gameObject);
//		}
//	}

	void OnCollisionExit2D(Collision2D o){
		if(o.gameObject.CompareTag("Plank")){
			Destroy (o.gameObject);
		}
	}
}
