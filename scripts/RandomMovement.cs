using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour {

	public Rigidbody rb;
	public int speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Movimiento
	void FixedUpdate () {
		rb.AddForce(Random.onUnitSphere * speed);
	}
}
