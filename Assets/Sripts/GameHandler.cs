using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    private static GameHandler instance;

    private LevelGrid levelGrid;
    [SerializeField] private Snake snake;

    private void Awake()
    {
        instance = this;
        Score.InitialiyeStatic();
        Time.timeScale = 1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        levelGrid = new LevelGrid(20, 20);
        snake.Setup(levelGrid);
        levelGrid.Setup(snake);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (IsGamePause()) 
            {
                GameHandler.ResumeGame();
            } else {
                GameHandler.PauseGame();
            }           
        }
    }

    public static void SnakeDied() 
    {
        Score.TrySetNewHighscore();
        GameOverWindow.ShowStatic();
    }

    public static void ResumeGame() 
    {
        PauseWindow.HideStatic();
        Time.timeScale = 1f;
    }

    public static void PauseGame() 
    {
        PauseWindow.ShowStatic();
        Time.timeScale = 0f;
    }

    public static bool IsGamePause() 
    {
        return Time.timeScale == 0f;
    }
}
