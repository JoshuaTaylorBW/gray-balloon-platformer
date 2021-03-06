using UnityEngine;
using System.Collections;

public class CenteredCameraController : MonoBehaviour {

	public GameObject protagonist;
	public float endPosition;

	// Use this for initialization
	void Start () {
		protagonist = GameObject.Find("Character");
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (protagonist.transform.position.x > transform.position.x && protagonist.transform.position.x < endPosition){
			transform.position = new Vector3(protagonist.transform.position.x, 0, -10);
		}
	}
}
