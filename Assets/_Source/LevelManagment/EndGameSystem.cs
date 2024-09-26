using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameSystem : MonoBehaviour
{
    [SerializeField] private GameObject _endGame;
    private GameState _gameState;

    private void Awake()
    {
        _gameState = GameState.InGame;
        _endGame.SetActive(false);
    }
    private void Update()
    {
        WinGame();
    }
    public bool CheckInGame()
    {
        return _gameState == GameState.InGame ? true : false;
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
        _gameState = GameState.Win;
        _endGame.SetActive(true);
    }
}
public enum GameState
{
    Win,
    Lose,
    InGame
}