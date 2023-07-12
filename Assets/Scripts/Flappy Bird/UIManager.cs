using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;
    public TextMeshProUGUI textScore;
    public GameObject buttonStartGame;
    public UILoseGame loseGamePannel;
    public GameObject splashScreen;
   
    // Start is called before the first frame update
    void Start()
    {
        splashScreen.SetActive(false);
        Instance = this;
        UpdateScore(0);
    }
    public void StartGameOnClicked()
    {
        GameManager.Instance.StartGame();
        buttonStartGame.SetActive(false);
    }
    public void PauseGame()
    {
        GameManager.Instance.PauseGame();
    }
    // Update is called once per frame
    public void UpdateScore(int score)
    {
        textScore.text = score.ToString();
    }
    public void LoseGame()
    {
        StartCoroutine(WaitForLose());
    }
   private IEnumerator WaitForLose ()
    {
        splashScreen.SetActive (true);
        yield return new WaitForSeconds(0.2f);
        splashScreen.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        loseGamePannel.Show();
        int playerScore = GameManager.Instance.GetScore();
        loseGamePannel.SetPlayerScoreText(playerScore);
        loseGamePannel.SetMedalImage(playerScore);
    }
} 
