using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.LevelManagment
{
    public class EndGameSystem : MonoBehaviour
    {
        [Header("References")]
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
}
public enum GameStateEnum
{
    Win,
    Lose,
    InGame
}