using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUi : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;
    
    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditButton.onClick.AddListener(PlayCredit);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("pinball");
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    private void PlayCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}
