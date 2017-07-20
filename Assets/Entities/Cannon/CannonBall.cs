using UnityEngine;
using System.Collections;

public class CannonBall : MonoBehaviour {

	private CharacterController controller;
	public float ballAngle;
	public float ballSpeed;
	public Vector3 whateverThisIs;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	void SetAngle(float angle){
		ballAngle = angle;
		transform.localEulerAngles = new Vector3(0, 0, angle);
	}

	void SetSpeed(float speed){
		ballSpeed = speed;	
	}

	void Update () {
		//whateverThisIs = transform.TransformDirection(Vector3.forward) * ballSpeed;
		controller.Move(transform.right * Time.deltaTime * ballSpeed);
	}


}
