using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score main;

    private int _scorePoints;

    private void Awake()
    {
        main = this;
    }
    private void Start()
    {
        _scorePoints = 0;
    }
    public void AddPoints(int points)
    {
        _scorePoints += points;
    }
    public int GetPoints()
    {
        return _scorePoints;
    }
}
