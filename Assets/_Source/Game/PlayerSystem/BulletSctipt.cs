using System.Collections;
using UnityEngine;
using Game.EnemySystem;

namespace Game.PlayerSystem
{
    public class BulletSctipt : MonoBehaviour
    {
        [Header("Attributes")]
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
                other.gameObject.GetComponent<EnemyHealth>().HitEnemy();
                Destroy(gameObject);
            }
        }
    }
}