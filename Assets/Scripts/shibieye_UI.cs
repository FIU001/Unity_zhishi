using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shibieye_UI : MonoBehaviour {

 
    public Button fanhuisy;
    void Start () {
        
        fanhuisy.onClick.AddListener(fanhuishouyejb);
    }
	
   
    
    void fanhuishouyejb()
    {
        SceneManager.LoadScene("shouye");
    }
    // Update is called once per frame
    void Update () {
		
	}
   
    
}
