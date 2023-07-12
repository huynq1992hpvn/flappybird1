using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILoseGame : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI bestScoreText;
    public Image medalImage;
    
    public Sprite goldSprite;
    public Sprite silverSprite;
    public Sprite bonzeSprite;
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void SetPlayerScoreText(int score)
    {
        playerScoreText.text = score.ToString();
    }
    public void SetBestScoreText (int bestcore)
    {
        bestScoreText.text = bestcore.ToString();
    }
    public void SetMedalImage (int score)
    {
        if (score >= 7)
        {
            medalImage.sprite = goldSprite;
        }
        else if (score >=4 )
        {
            medalImage.sprite = silverSprite;
        }
        else
        {
            medalImage.sprite = bonzeSprite;
        }
    }
}
