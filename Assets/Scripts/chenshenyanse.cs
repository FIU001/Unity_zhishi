using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chenshenyanse : MonoBehaviour
{
    public Material cubebody;
    // Use this for initialization
  

    public void ButtondownGrey()
    {
        cubebody.color = Color.grey;
    }
    public void ButtondownBlack()
    {
        cubebody.color = Color.black;
    }
	public void ButtondownWhite()
	{
		cubebody.color = Color.white;
	}
}
