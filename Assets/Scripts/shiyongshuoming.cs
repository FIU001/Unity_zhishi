using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class shiyongshuoming : MonoBehaviour {
    public GameObject xiangqian;
    public GameObject xianghou;
    public Button xiangqian_bt;
    public Button xianghou_bt;
    Sprite chushihua;
    public Sprite qiehuantu;
    public Image shuomingtu;
    public Button fanhuishangyiye_bt;


	// Use this for initialization
	void Start () {

        chushihua = shuomingtu.sprite;
        xiangqian.gameObject.SetActive(false);
        xiangqian_bt.onClick.AddListener(xiangqian_sq);
        xianghou_bt.onClick.AddListener(xianghou_sq);
        fanhuishangyiye_bt.onClick.AddListener(fanhuishangyiye_sq);
    }
    void xianghou_sq()
    {
        if (shuomingtu.sprite == chushihua)
        {
            shuomingtu.sprite = qiehuantu;
            xiangqian.gameObject.SetActive(true);
            xianghou.gameObject.SetActive(false);
        }
        else
        {
            shuomingtu.sprite = chushihua;
            xiangqian.gameObject.SetActive(true);
            xianghou.gameObject.SetActive(false);

        }
    }
    void xiangqian_sq()
    {
        shuomingtu.sprite = chushihua;
        xiangqian.gameObject.SetActive(false);
        xianghou.gameObject.SetActive(true);
    }
    void fanhuishangyiye_sq()
    {
        SceneManager.LoadScene("shouye");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
