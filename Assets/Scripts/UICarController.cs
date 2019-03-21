using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UICarController : MonoBehaviour
{
    public Button openDoorButton;//开门按钮
    //public Button openLightButton;//开灯按钮
    public Button openVideoButton;//视频按钮
 
    public Animation Car_an;
    public AudioSource kaimen_Audio;
    public AudioSource mingdi_Audio;
    
    Sprite oDoorNomalSprite;//初始开门按钮图片
    //Sprite oLightNomalSprite;//初始开灯按钮图片

    public Sprite oDSprite;//资源图片，开门按钮图片
    //public Sprite oLSprite;//资源图片，开灯按钮图片


    //	 Use this for initialization
    void Start()
    {
        oDoorNomalSprite = openDoorButton.image.sprite;
        //oLightNomalSprite = openLightButton.image.sprite;

        openDoorButton.onClick.AddListener(openDoorButtonOnClick);
        //openLightButton.onClick.AddListener(openLightButtonOnClick);
        openVideoButton.onClick.AddListener(openVideoButtonOnClick);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    /// <summary>
    /// 开门按钮点击事件
    /// </summary>
    void openDoorButtonOnClick()
    {
        //如果当前按钮图片==按钮初始图片，点击后更换为新图片。
        if (openDoorButton.image.sprite == oDoorNomalSprite)
        {
            openDoorButton.image.sprite = oDSprite;
            Car_an["kaimen_an"].speed = 1;
            Car_an.Play("kaimen_an");
            mingdi_Audio.Play();
        }
        else
        {

            //否则更换为初始图片
            openDoorButton.image.sprite = oDoorNomalSprite;
            Car_an["kaimen_an"].speed = -1;
            Car_an.Play("kaimen_an");
            kaimen_Audio.Play();

        }
    }
    /// <summary>
    /// 开灯按钮点击事件
    /// </summary>
    //void openLightButtonOnClick()
    //{
    //    if(openLightButton.image.sprite== oLightNomalSprite)
    //    {
    //        openLightButton.image.sprite = oLSprite;
    //        mingdi_Audio.Play();
    //    }
    //    else
    //    {
    //        openLightButton.image.sprite = oLightNomalSprite;
    //    }
    //}
    /// <summary>
    /// 视频按钮点击
    /// </summary>
    void openVideoButtonOnClick()
    {
        SceneManager.LoadScene("shibieye2");
    }
    /// <summary>
    /// 游戏按钮点击
    /// </summary>
   
}


