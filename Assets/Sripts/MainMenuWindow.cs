using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuWindow : MonoBehaviour
{
    public Button playBtn;
    public Button howToPlayBtn;
    public Button quitBtn;
    public Button backBtn;

    private enum Sub 
    {
        Main,
        HowToPlay,
    }

    private void Awake()
    {
        playBtn.onClick.AddListener(() => Loader.Load(Loader.Scene.GameScene));

        transform.Find("HowToPlaySub").Find("howToPlay").GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        quitBtn.onClick.AddListener(() => Application.Quit());

        howToPlayBtn.onClick.AddListener(() => ShowSub(Sub.HowToPlay));
        backBtn.onClick.AddListener(() => ShowSub(Sub.Main));

        ShowSub(Sub.Main);
    }

    private void ShowSub(Sub sub) 
    {
        transform.Find("MainSub").gameObject.SetActive(false);
        transform.Find("HowToPlaySub").gameObject.SetActive(false);

        switch (sub) 
        {
            case Sub.Main:
                transform.Find("MainSub").gameObject.SetActive(true);
                break;
            case Sub.HowToPlay:
                transform.Find("HowToPlaySub").gameObject.SetActive(true);
                break;
        }
    }
}
