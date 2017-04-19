using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController : MonoBehaviour {

	public float upperBounds = 480f;
	public float lowerBounds = -480f;
	public float leftBounds = 160f;
	public float rightBounds = -160f;
	public float speedY = 5f;

	// Use this for initialization
	void Start () {
		this._reset ();
	}

	private void _reset() {
		transform.position = new Vector2 (this.leftBounds, this.upperBounds);
	}


	private void _checkBounds() {
		if (transform.position.y <= this.lowerBounds) {
			this._reset ();
		}
	}


	// Update is called once per frame
	void Update () {
		// move the ocean down by speedY pixels every frame
		float currentYPosition = transform.position.y - this.speedY;
		transform.position = new Vector2(transform.position.x, currentYPosition);

		// check if the ocean has reached the lowerbounds
		this._checkBounds ();
	}
}
