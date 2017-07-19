using UnityEngine;
using System.Collections;

public class MovingRightCameraController : MonoBehaviour {
	public GameObject protagonist;
	public float moveSpeed;
	private CharacterController controller;
	public float endPosition;
	private Vector3 velocity;

	// Use this for initialization
	void Start () {
		protagonist = GameObject.Find ("Character");
		controller = GetComponent<CharacterController>();
		velocity = new Vector3(moveSpeed, 0, 0);
	}

	void FixedUpdate () {
		controller.Move(velocity * Time.deltaTime);
	}
}
