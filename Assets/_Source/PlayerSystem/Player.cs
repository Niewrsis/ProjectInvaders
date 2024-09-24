using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _movmentSpeed;

    public Player(float movmentSpeed, Transform transform)
    {
        _movmentSpeed = movmentSpeed;
    }
}
