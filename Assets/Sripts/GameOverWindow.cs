using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverWindow : MonoBehaviour
{
    private static GameOverWindow instance;
    public Button retryBtn;

    private void Awake()
    {
        instance = this;
        retryBtn.onClick.AddListener(() => Loader.Load(Loader.Scene.GameScene));
        Hide();
    }

    private void Show() 
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public static void ShowStatic() 
    {
        instance.Show();
    }
}
