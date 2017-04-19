using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {

	public float leftBounds = -132f;
	public float rightBounds = 132f;
	public float fixedYPosition = -190f;

	// Use this for initialization
	void Start () {
		
	}

	private void _movePlane() {
		transform.position = new Vector2 (Input.mousePosition.x - 160f, this.fixedYPosition);

	}

	private void _checkBounds() {
		if (transform.position.x < this.leftBounds) {
			transform.position = new Vector2 (this.leftBounds, this.fixedYPosition);
		}

		if (transform.position.x > this.rightBounds) {
			transform.position = new Vector2 (this.rightBounds, this.fixedYPosition);
		}
	}


	// Update is called once per frame
	void Update () {

		// move the plane where the user presses on the screen
		this._movePlane ();

		// ensure the plane stays on the screen
		this._checkBounds ();
	}
}
