using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Button jietufx;

    // Use this for initialization
    void Start ()
    {
        jietufx.onClick.AddListener(jietufenxiang);

    }
	
		// Update is called once per frame
		void jietufenxiang ()
		{
        Share.instance.ScreenShot();
        Share.instance.CallShare("share", "", "#知梦团队出品~", true);
    }
}
