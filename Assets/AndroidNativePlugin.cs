﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidNativePlugin {

	public static void OpenSettings()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            using (var javaUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                using (var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
                {
                    using (var callSettingsPanelPlugin = new AndroidJavaObject("com.Nebr.AndroidNativePlugin.AndroidNativePlugin", currentActivity))
                    {
                        callSettingsPanelPlugin.Call("OpenSettings");
                    }
                }
            }
        }
	}

    public static void OpenGallery()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            using (var javaUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                using (var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
                {
                    using (var callSettingsPanelPlugin = new AndroidJavaObject("com.Nebr.AndroidNativePlugin.AndroidNativePlugin", currentActivity))
                    {
                        callSettingsPanelPlugin.Call("OpenGallery");
                    }
                }
            }
        }
    }

    public static void OpenCamera()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            using (var javaUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                using (var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
                {
                    using (var callSettingsPanelPlugin = new AndroidJavaObject("com.Nebr.AndroidNativePlugin.AndroidNativePlugin", currentActivity))
                    {
                        callSettingsPanelPlugin.Call("OpenCamera");
                    }
                }
            }
        }
    }


    public static void Flashlight()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            using (var javaUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                using (var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
                {
                    using (var callSettingsPanelPlugin = new AndroidJavaObject("com.Nebr.AndroidNativePlugin.AndroidNativePlugin", currentActivity))
                    {
                        callSettingsPanelPlugin.Call("Flashlight");
                    }
                }
            }
        }
    }

    public static void Vibrate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            using (var javaUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                using (var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
                {
                    using (var callSettingsPanelPlugin = new AndroidJavaObject("com.Nebr.AndroidNativePlugin.AndroidNativePlugin", currentActivity))
                    {
                        callSettingsPanelPlugin.Call("Vibrate");
                    }
                }
            }
        }
    }

    public static void Vibrate2()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            using (var javaUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                using (var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
                {
                    using (var callSettingsPanelPlugin = new AndroidJavaObject("com.Nebr.AndroidNativePlugin.AndroidNativePlugin", currentActivity))
                    {
                        callSettingsPanelPlugin.Call("Vibrate2");
                    }
                }
            }
        }
    }
}
