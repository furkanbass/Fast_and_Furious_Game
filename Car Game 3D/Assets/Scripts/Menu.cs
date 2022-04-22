using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject MainMenu;     //GameObject MainMenu is defined.
    public GameObject SettingsMenu; //GameObject SettingsMenu is defined.

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();   //Main Menu Button is defined for to start.
    }

    public void StartGameButton()
    {
        // Start Game Button has been pressed, here you can initialize your game.
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void SettingsButton()
    {
        // Show Settings Menu
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }
}