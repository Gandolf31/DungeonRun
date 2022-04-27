using PixelsoftGames.PixelUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCtrl : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Enchant()
    {
        SceneManager.LoadScene("Enchant");
    }
    public void GoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
