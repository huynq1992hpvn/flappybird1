using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonPauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Image imageButton;
    public Sprite buttonPauseSprite;
    public Sprite buttonResumeSprite;
    public void Start()
    {
        imageButton.sprite = buttonPauseSprite;
    }
    public void PauseGameOnClicked()
    {
        UIManager.Instance.PauseGame();
        changeButtonImage();
        
    }
    public void changeButtonImage()
    {
        if (GameManager.Instance.isPauseGame)
        {
            imageButton.sprite = buttonResumeSprite;
        }
        else
        {
            imageButton.sprite = buttonPauseSprite;
        }
    }
}
