using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;


public class UILoseGame : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI bestScoreText;
    public Image medalImage;

    public Sprite goldSprite;
    public Sprite silverSprite;
    public Sprite bonzeSprite;
    public List<GameObject> listButtons = new List<GameObject>();
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void SetPlayerScoreText(int score)
    {
        StartCoroutine(CountingScore(score, 2f));
    }
    private IEnumerator CountingScore(int target, float duration)
    {
        playerScoreText.text = 0.ToString();
        yield return new WaitForSeconds(1f);
        if (target != 0)
        {


            float yieldTime = duration / target;
            for (int i = 0; i <= target; i++)
            {
                playerScoreText.text = i.ToString();
                yield return new WaitForSeconds(yieldTime);
            }
        }
        for (int i = 0; i< listButtons.Count; i++)
        {
            listButtons[i].SetActive(true);
        }
    }

    public void SetBestScoreText(int bestcore)
    {
        bestScoreText.text = bestcore.ToString();
    }
    public void SetMedalImage(int score)
    {
        if (score >= 7)
        {
            medalImage.sprite = goldSprite;
        }
        else if (score >= 4)
        {
            medalImage.sprite = silverSprite;
        }
        else
        {
            medalImage.sprite = bonzeSprite;
        }
    }
    public void PlayAgainOnClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
