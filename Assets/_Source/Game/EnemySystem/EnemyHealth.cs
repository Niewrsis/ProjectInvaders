using UnityEngine;
using Game.LevelManagment;

namespace Game.EnemySystem
{
    public class EnemyHealth : MonoBehaviour
    {
        public void HitEnemy()
        {
            Score.main.AddPoints(50);
            Destroy(gameObject);
        }
    }
}