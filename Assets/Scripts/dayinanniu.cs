using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dayinanniu : MonoBehaviour {
    public GameObject dayinjiemian;
    public Button shouye_dayin;
    public Button guanbi_dayin;
    public Button shuoming_bt;
	// Use this for initialization
	void Start () {
        dayinjiemian.gameObject.SetActive(false);
        shouye_dayin.onClick.AddListener(xianshidayin);
        guanbi_dayin.onClick.AddListener(yincangdayin);
        shuoming_bt.onClick.AddListener(shuoming_sq);
    }
	void xianshidayin()
    {
        dayinjiemian.gameObject.SetActive(true);
    }
    void yincangdayin()
    {
        dayinjiemian.gameObject.SetActive(false);
    }
    void shuoming_sq()
    {
        SceneManager.LoadScene("shiyongshuoming");
    }
    //Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        { Application.Quit(); }

    }
}
