using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Start_UI : MonoBehaviour {
    public Button jinru_button;


	// Use this for initialization
	void Start () {
        jinru_button.onClick.AddListener(jinru_sq);
		
	}
	void jinru_sq()
    {
        SceneManager.LoadScene("shibieye");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
