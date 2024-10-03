using UnityEngine;
using Game.LevelManagment;

namespace Game
{
    public class RedZoneSystem : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            EndGameSystem.GameState = GameStateEnum.Lose;
        }
    }
}