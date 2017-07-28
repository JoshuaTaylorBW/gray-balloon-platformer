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
	
	void Stop () {
		StopCoroutine("spawnCannonBalls");
	}

	void MakeCannonball(){
		cannonBall = Instantiate(Resources.Load("Cannon-Ball"), transform.position, Quaternion.identity) as GameObject;
		cannonBall.SendMessage("SetAngle", CannonAngle);	
		cannonBall.SendMessage("SetSpeed", CannonSpeed);
		cannonBall.SendMessage("SetCannon", this.gameObject);
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
