using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private SwitcherOfPipes _switcherOfPipes;
    [SerializeField] private PlayerController _controller;

    public void ResetGame()
    {
        _switcherOfPipes.SwitchOffAllPipes();
        _controller.SetStartPosition();
        Time.timeScale = 1;
        _gameOver.SetActive(false);
    }
}
