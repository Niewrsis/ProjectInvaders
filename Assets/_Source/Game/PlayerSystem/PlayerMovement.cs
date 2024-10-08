using UnityEngine;

namespace Game.PlayerSystem
{
    public class PlayerMovement
    {
        public void MoveLeft(Transform transform, float moveSpeed)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime, Camera.main.transform);
        }

        public void MoveRight(Transform transform, float moveSpeed)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime, Camera.main.transform);
        }
    }
}