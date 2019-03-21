using UnityEngine;
using System.Collections;
using UnityEngine.UI;//注意这个不能少

public class yincangxialacaidan : MonoBehaviour {
	public GameObject btnObj ;//定义按钮
	public GameObject caidan;//定义菜单变量
	public Sprite   expan;//定义待用的按钮图标
	public Sprite  back;
	Button btn;//声明按钮
	bool isshow=false ;//是否显示菜单
	// 初始化
	void Start () {
		caidan.SetActive (isshow);
		btn = btnObj.GetComponent<Button>();
		btn.onClick.AddListener(delegate ()
			{
				isshow=!isshow;
				caidan.SetActive (isshow);
				if (isshow)
				{
					//改变按钮图标
					btn.GetComponent<Image>().sprite=expan ;
				}
				else {
					btn.GetComponent<Image>().sprite=back;
				}
			});
	}

	// Update is called once per frame
	void Update () {

	}
}