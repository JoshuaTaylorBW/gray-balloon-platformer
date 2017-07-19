using UnityEngine;
using System.Collections;
using UnityEngine.UI;	

public class PauseButton : MonoBehaviour {

	public bool paused;
	public Canvas menu;
	public Button resume;
	public Button exit;
	private float halfScreenWidth;
	private float screenHeight;

	void Start () {
		halfScreenWidth = Screen.width / 2;	
		screenHeight = Screen.height;
		resume.image.rectTransform.sizeDelta = new Vector2(halfScreenWidth, screenHeight);
		resume.image.rectTransform.anchoredPosition = new Vector2(halfScreenWidth / 2, 0);
		exit.image.rectTransform.sizeDelta = new Vector2(halfScreenWidth, screenHeight);
		exit.image.rectTransform.anchoredPosition = new Vector2(-halfScreenWidth / 2, 0);
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			togglePause();
		}
	}

	public void togglePause(){
		if(!paused){
			menu.enabled = true;
			Time.timeScale = 0;	
			paused = true;
		}else{
			menu.enabled = false;
			Time.timeScale = 1;	
			paused = false;
		}
	}

	public void quit(){
		Application.LoadLevel("Temp_menu");
	}

}
