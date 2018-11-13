using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSensor : MonoBehaviour {

	public Color ethanLight = new Color(0.65f, 0.87f, 0.87f);
	public Color ethanMedium = new Color(0.09f, 0.87f, 0.89f);
	public Color ethanDark = new Color(0.09f, 0.7f, 0.73f);

	public Color sphereLight = new Color(1f, 0.45f, 0.66f);
	public Color sphereMedium = new Color(1f, 0.1f, 0.53f);
	public Color sphereDark = new Color(0.64f, 0f, 0.35f);

	public Renderer rd;

	Color ogColor;
	bool leftCol;

	// Use this for initialization
	void Start () {
		rd = GetComponent<Renderer> ();
		ogColor = rd.material.color;
		leftCol = false;
	}

	void Update() {
		if (leftCol) {
			leftCol = false;
			rd.material.color = ogColor;
		}
		else if (rd.material.color != ogColor)
			leftCol = true;
		// Volver al color original
	}
	
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "MyEthan") {
			rd.material.color = ethanLight;
		}
		else if (col.gameObject.tag == "MySphere") {
			rd.material.color = sphereLight;
		}
	}

	void OnCollisionStay(Collision col) {
		if (col.gameObject.tag == "MyEthan") {
			rd.material.color = ethanMedium;
		}
		else if (col.gameObject.tag == "MySphere") {
			rd.material.color = sphereMedium;
		}
	}

	void OnCollisionExit(Collision col) {
		if (col.gameObject.tag == "MyEthan") {
			rd.material.color = ethanDark;
		}
		else if (col.gameObject.tag == "MySphere") {
			rd.material.color = sphereDark;
		}
	}

}
