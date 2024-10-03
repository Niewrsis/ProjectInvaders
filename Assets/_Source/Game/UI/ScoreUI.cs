using TMPro;
using UnityEngine;
using Game.LevelManagment;

namespace Game.UI
{
    public class ScoreUI : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private TextMeshProUGUI _scoreValueText;

        private void Update()
        {
            _scoreValueText.text = Score.main.GetPoints().ToString();
        }
    }
}