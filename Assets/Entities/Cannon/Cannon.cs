using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {

	private CharacterController controller;
	public float CannonAngle;
	public float CannonFrequency;
	public float CannonSpeed;
	public bool CannonIsOnScreen = true;
	private GameObject cannonBall;

	// Use this for initialization
	void Start () {
		CannonAngle = transform.rotation.eulerAngles.z; 
		StartCoroutine(spawnCannonBalls());
	}
	
	// Update is called once per frame
	void Update () {

	}

	void MakeCannonball(){
		cannonBall = Instantiate(Resources.Load("Cannon-Ball"), transform.position, Quaternion.identity) as GameObject;
		cannonBall.SendMessage("SetAngle", CannonAngle);	
		cannonBall.SendMessage("SetSpeed", CannonSpeed);
	}

	IEnumerator spawnCannonBalls()
	{
		while (true)
		{
			while(CannonIsOnScreen){
				MakeCannonball();
				yield return new WaitForSeconds(CannonFrequency);
			}
		}
	}
}
