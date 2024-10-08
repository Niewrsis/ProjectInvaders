using System.Collections;
using UnityEngine;

namespace Game.EnemySystem
{
    public class EnemiesMovement : MonoBehaviour
    {
        [Header("Attributes")]
        [SerializeField] private float _stepSize;
        [SerializeField] private float _timeBeetwenSteps;

        private void Start()
        {
            StartCoroutine(TimeToNextStep());
        }
        private IEnumerator TimeToNextStep()
        {
            while (true)
            {
                yield return new WaitForSeconds(_timeBeetwenSteps);
                transform.Translate(Vector3.down * _stepSize);
            }
        }
    }
}