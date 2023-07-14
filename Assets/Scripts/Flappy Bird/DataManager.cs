using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public int CurrentScore = 0;
    private void Awake()
    {
        Instance = this;
        if (!PlayerPrefs.HasKey("FirstPlay"))
        {
            Debug.Log("Day la lan dau vao game");
            PlayerPrefs.SetInt("BestScore", 0);
            PlayerPrefs.SetInt("FirstPlay", 0);
            
        }
    }
    public int GetScore()
    {
        return CurrentScore;
    }
    public void AddScore()
    {
        CurrentScore++;
        
    }
   
    public void SetBestScore()
    {
        int lastBestScore = PlayerPrefs.GetInt("BestScore");
        if(CurrentScore > lastBestScore)
        {
            PlayerPrefs.SetInt("BestScore", CurrentScore);
        }
    }
}

