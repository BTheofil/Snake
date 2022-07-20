using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    private static Action loaderCallbackAction;

    public enum Scene
    {
        GameScene,
        Loading,
        MainMenu
    }

    public static void Load(Scene scene)
    {
        loaderCallbackAction = () =>
        {
            SceneManager.LoadScene(Scene.Loading.ToString());
        };
        
        SceneManager.LoadScene(scene.ToString());
    }

    public static void LoaderCallback() 
    {
        if (loaderCallbackAction != null) 
        {
            loaderCallbackAction();
            loaderCallbackAction = null;
        }
    }
}
