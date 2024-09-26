using UnityEngine;

public class PlayerMovement
{
    public void MoveLeft(Transform transform, float moveSpeed)
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
    
    public void MoveRight(Transform transform, float moveSpeed)
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}
