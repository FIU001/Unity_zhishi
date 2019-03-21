using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shouye_audio : MonoBehaviour
{
    public Button sysy_bt;
    public AudioSource sysy;
    Sprite chushisy;
    public Sprite bofang;

    // Use this for initialization
    void Start()
    {
        chushisy = sysy_bt.image.sprite;
        sysy_bt.onClick.AddListener(mysy);


    }
    void mysy()
    {

        if (sysy_bt.image.sprite == chushisy)
        {
            sysy_bt.image.sprite = bofang;
            sysy.Pause();
        }
        else
        {
            sysy_bt.image.sprite = chushisy;
            sysy.Play();
        }
    }
}