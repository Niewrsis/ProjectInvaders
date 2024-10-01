using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameSystem : MonoBehaviour
{
    [SerializeField] private GameObject _endGame;
    public static GameStateEnum GameState;

    private void Awake()
    {
        _endGame.SetActive(false);
        GameState = GameStateEnum.InGame;
    }
    private void Update()
    {
        LoseGame();
        WinGame();
    }
    public void RetryLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    private void WinGame()
    {
        if (transform.childCount != 0) return;

        Time.timeScale = 0f;
        _endGame.SetActive(true);
    }
    private void LoseGame()
    {
        if (GameState == GameStateEnum.InGame || GameState == GameStateEnum.Win) return;

        Time.timeScale = 0f;
        _endGame.SetActive(true);
    }
}
public enum GameStateEnum
{
    Win,
    Lose,
    InGame
}