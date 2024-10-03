using UnityEngine;

namespace Game.EnemySystem
{
    public class EnemyRow : MonoBehaviour
    {
        private void Update()
        {
            if (transform.childCount == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}