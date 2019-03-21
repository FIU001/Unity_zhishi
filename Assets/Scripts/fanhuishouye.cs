using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class fanhuishouye : MonoBehaviour {
    public Button fanhuishouye_bt;


	// Use this for initialization
	void Start () {
        fanhuishouye_bt.onClick.AddListener(fanhui);
	}
	
	void fanhui()
    {
        SceneManager.LoadScene("shouye", LoadSceneMode.Single);
    }
}
