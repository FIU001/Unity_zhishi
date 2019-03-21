using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class fanhuisheibie : MonoBehaviour {
    public Button fanhuishibie_bt;
	// Use this for initialization
	void Start () {
        fanhuishibie_bt.onClick.AddListener(fanhuishibie_sq);

	}
    void fanhuishibie_sq()
    {
        SceneManager.LoadScene("shibieye");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
