using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private TMP_Text _scoreBoard;

    private int _score;

    public void ChangeScore(int value)
    {
        _score += value;
        _scoreBoard.text = _score.ToString();
    }

    public void Die()
    {
        _score = 0;
        _gameOver.SetActive(true);
        Time.timeScale = 0;
        _scoreBoard.text = _score.ToString();
    }
}
