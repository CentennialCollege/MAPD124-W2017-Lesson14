using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandController : MonoBehaviour {

	public float upperBounds = 270f;
	public float lowerBounds = -270f;
	public float leftBounds = -128f;
	public float rightBounds = 128f;
	public float speedY = 5f;


	// Use this for initialization
	void Start () {
		this._reset ();
	}

	private void _reset() {
		transform.position = new Vector2 (Random.Range (leftBounds, rightBounds), upperBounds);
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
