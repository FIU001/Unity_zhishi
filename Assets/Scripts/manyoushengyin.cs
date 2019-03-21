using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class manyoushengyin : MonoBehaviour {
    public Button changjingsy;
    public AudioSource manyoubg;
    Sprite chushimanyou;
    public Sprite bofang;
  
    // Use this for initialization
    void Start () {
        chushimanyou = changjingsy.image.sprite;
        changjingsy.onClick.AddListener(mysy);
       

    }
    void mysy()
    {
        
        if (changjingsy.image.sprite == chushimanyou)
        {
            changjingsy.image.sprite = bofang;
            manyoubg.Pause();
        }
        else
        {
            changjingsy.image.sprite = chushimanyou;
            manyoubg.Play();
        }
    }
	
	// Update is called once per frame
	
}
