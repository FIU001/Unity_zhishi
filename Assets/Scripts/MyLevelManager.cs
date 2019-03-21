using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine .SceneManagement ;
using UnityEngine .UI ;

public class MyLevelManager : MonoBehaviour {
	static string nextLevel;
	AsyncOperation async;
	public Slider slider;
	public Text text;

	// Use this for initialization
	void Start () {
		if (SceneManager.GetActiveScene ().name == "Load") {
			async=SceneManager.LoadSceneAsync (nextLevel);		
		}
	}
	public void LoadLoadingLevel(string nextLevelName){
		nextLevel = nextLevelName;
		SceneManager .LoadSceneAsync ("Load");
	}
	// Update is called once per frame
	void Update () {
		if (text && slider) {
			text .text=( async.progress/9*10*100).ToString ()+"%";
			slider.value = async.progress/9*10;
		}
	}
}
