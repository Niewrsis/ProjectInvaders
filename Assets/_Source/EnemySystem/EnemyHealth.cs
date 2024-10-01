using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public void HitEnemy()
    {
        Score.main.AddPoints(50);
        Destroy(gameObject);
    }
}
