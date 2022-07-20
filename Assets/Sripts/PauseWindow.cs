using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class PauseWindow : MonoBehaviour
{
    public Button mainMenu;
    public Button resumeBtn;

    private static PauseWindow instance;

    private void Awake()
    {
        instance = this;

        transform.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        transform.GetComponent<RectTransform>().sizeDelta = Vector2.zero;

        mainMenu.onClick.AddListener(() => Loader.Load(Loader.Scene.MainMenu));
        resumeBtn.onClick.AddListener(() => GameHandler.ResumeGame());


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

    public static void HideStatic() 
    {
        instance.Hide();
    }
}
