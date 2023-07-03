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
    public GameObject loseGamePannel;
    public Image imageMedalButton;
    public Sprite buttonBonzeSprite;
    public Sprite buttonSilverSprite;
    public Sprite buttonGoldSprite;
    // Start is called before the first frame update
    void Start()
    {
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
        loseGamePannel.SetActive(true);
    }
    public void UIMedal(int score)
    {
        if (score >= 8)
        {
            // Hiển thị huy chương vàng
            imageMedalButton.sprite = buttonGoldSprite;
        }
        else if (score >= 5)
        {
            // Hiển thị huy chương bạc
            imageMedalButton.sprite = buttonSilverSprite;
        }
        else if (score >= 0)
        {
            // Hiển thị huy chương đồng
            imageMedalButton.sprite = buttonBonzeSprite;
        }
    }
} 
