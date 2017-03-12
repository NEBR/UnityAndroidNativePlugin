using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour {

	public void OnClick_OpenSettings()
	{
		AndroidNativePlugin.OpenSettings();
	}

    public void OnClick_OpenGallery()
    {
        AndroidNativePlugin.OpenGallery();
    }

    public void OnClick_OpenCamera()
    {
        AndroidNativePlugin.OpenCamera();
    }

    public void OnClick_Flashlight()
    {
        AndroidNativePlugin.Flashlight();
    }

    public void OnClick_Vibrate()
    {
        AndroidNativePlugin.Vibrate();
    }

    public void OnClick_Vibrate2()
    {
        AndroidNativePlugin.Vibrate2();
    }
}
