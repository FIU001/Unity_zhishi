using UnityEngine;
using System.Collections;

public class duijiao : MonoBehaviour
{

    void Start()
    {
        GameObject ARCamera = GameObject.Find("ARCamera");

        Vuforia.CameraDevice.Instance.SetFocusMode(Vuforia.CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    void Update()
    {
        Vuforia.CameraDevice.Instance.SetFocusMode(Vuforia.CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
}
