using UnityEngine;
using System.Collections;

public class CannonBall : MonoBehaviour {

	private Rigidbody rb;
	public GameObject protagonist;
	public GameObject cannon;
	public float ballAngle;
	public float ballSpeed;
	public Vector3 whateverThisIs;
	private Vector3 velocity;
	private bool done = false;

	// Use this for initialization
	void Start () {
		protagonist = GameObject.Find("Character");
		rb = GetComponent<Rigidbody>();

	}
	
	void SetAngle(float angle){
		ballAngle = angle;
		transform.localEulerAngles = new Vector3(0, 0, angle);
	}

	void SetCannon(GameObject cannon){
		this.cannon = cannon;	
	}

	void SetSpeed(float speed){
		ballSpeed = speed;	
	}

	void Update () {
		rb.AddForce(transform.right * (ballSpeed / 1000));
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.name == "Character" && !done){
			protagonist.SendMessage("die");
			Destroy(this.gameObject);
			cannon.SendMessage("Stop");
			done = true;
		}
	}


}
