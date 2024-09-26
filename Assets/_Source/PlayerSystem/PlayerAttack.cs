using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;

    private bool _isReloading = false;
    public void Shoot(Transform transform, float attackSpeed)
    {
        StartCoroutine(Reloading(attackSpeed));
    }
    private IEnumerator Reloading(float attackSpeed)
    {
        if (_isReloading) yield return null;

        _isReloading = true;
        Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(attackSpeed);
        _isReloading = false;
    }
}
