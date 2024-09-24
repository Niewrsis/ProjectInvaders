using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    public void MoveRight(Transform player, float movementSpeed)
    {
        player.Translate(0f, Vector2.right * movementSpeed, 0)
    }
}
