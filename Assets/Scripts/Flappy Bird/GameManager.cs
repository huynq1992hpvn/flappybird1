using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public bool isEndGame;
    
    public bool isStartGame;
    private bool isFirstCollision = false;
    public BirdController bird;
    public bool isPauseGame;
    private void Start()
    {
        Instance = this;
        isPauseGame = false;
        isStartGame = false;
    }

    public void StartGame()
    {
        isStartGame = true;
        bird.StartGame();
    }
    public void AddScore()
    {
        DataManager.Instance.AddScore();
        int playerscore = DataManager.Instance.GetScore();
        UIManager.Instance.UpdateScore(playerscore);
        AudioManager.Instance.PlayAudioScore();
      

    }
    public void PauseGame()
    {
        if (isPauseGame == false)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
    protected void Pause()
    {
        isPauseGame=true;
        Time.timeScale=0;
    }
    protected void Resume()
    {
        isPauseGame=false;
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        if (isFirstCollision == false)
        {
            DataManager.Instance.SetBestScore();
            isEndGame = true;
            AudioManager.Instance.PlayEndGameAudio();
            UIManager.Instance.LoseGame();
        }
        isFirstCollision = true;
    }
    public int GetScore()
    {
        return DataManager.Instance.GetScore();
    }
}

