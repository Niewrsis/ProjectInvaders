using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreValueText;

    private void Update()
    {
        _scoreValueText.text = Score.main.GetPoints().ToString();
    }
}
