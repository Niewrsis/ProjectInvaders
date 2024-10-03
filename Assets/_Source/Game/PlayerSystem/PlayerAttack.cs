using System.Collections;
using UnityEngine;

namespace Game.PlayerSystem
{
    public class PlayerAttack : MonoBehaviour
    {
        [Header("Refernces")]
        [SerializeField] private GameObject _bulletPrefab;

        private bool _isReloading = false;
        public void Shoot(Transform transform, float attackSpeed)
        {
            if (_isReloading) return;
            StartCoroutine(Reloading(attackSpeed));
        }
        private IEnumerator Reloading(float attackSpeed)
        {
            _isReloading = true;
            Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(attackSpeed);
            _isReloading = false;
        }
    }
}