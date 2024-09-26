using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSctipt : MonoBehaviour
{
    [SerializeField] private float flyingSpeed;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _rb.AddForce(Vector2.up * flyingSpeed);
        StartCoroutine(DestroyAfterTime());
    }
    private IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject != null)
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
    }
}
