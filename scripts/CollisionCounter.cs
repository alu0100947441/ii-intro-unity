using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCounter : MonoBehaviour {

	public int counter;

	// Use this for initialization
	void Start () {
		counter = 0;
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "MySphere" || collision.gameObject.tag == "MyCube")
			counter++;
		Debug.Log("contador: " + counter);
	}
}
