using UnityEngine;

public class RedZoneSystem : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        EndGameSystem.GameState = GameStateEnum.Lose;
    }
}
