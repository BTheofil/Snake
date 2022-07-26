using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWindow : MonoBehaviour
{
    private Text scoreText;

    private void Awake()
    {
        scoreText = transform.Find("scoreText").GetComponent<Text>();
    }

    private void Start()
    {
        Score.OnHighscoreChanged += Score_OnHighscoreChanged;
        UpdateHighscore();
    }

    private void Score_OnHighscoreChanged(object sender, System.EventArgs e) 
    {
        UpdateHighscore();
    }

    private void UpdateHighscore() 
    {
        int highscore = Score.GetHighscore();
        transform.Find("highscoreText").GetComponent<TMPro.TextMeshProUGUI>().text = "HIGHSCORE\n" + highscore.ToString();
    }

    private void Update()
    {
        scoreText.text = Score.GetScore().ToString();
    }
}
