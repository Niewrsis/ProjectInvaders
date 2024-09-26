using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [field: SerializeField] public float MovementSpeed { get; private set; }
    [field: SerializeField] public float AttackSpeed { get; private set; }

    private Rigidbody2D _rb;
    private Transform _transform;
    public Rigidbody2D Rb => _rb;
    public Transform Transform => _transform;
    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _rb = GetComponent<Rigidbody2D>();
    }
}
