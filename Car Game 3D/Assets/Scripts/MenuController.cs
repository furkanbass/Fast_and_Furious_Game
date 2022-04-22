using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string MenuSceneScene;   //MenuScene variable is defined.
    public GameObject pauseMenu;    //PauseMenu variable is defined.
    public bool isPaused;           //Boolean isPaused variable is defined.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
               ResumeGame();
            }
            else
            {
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
    public void ResumeGame()    //ResumeGame function.
    {
            isPaused = false;
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;   
    }
    public void ReturnToMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }
}