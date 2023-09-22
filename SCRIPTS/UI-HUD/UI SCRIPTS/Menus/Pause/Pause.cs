using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool IsPaused;
    
    [SerializeField] GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                resume();
            }
            else
            {
                PauseMenu();
            }
        }
    }
    public void PauseMenu()
    {
        IsPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;//pauses menu
    }

    
    public void resume()
    {
        IsPaused=false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;//menu disapears
    }

    public void Menu()
    {
        IsPaused = false;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(0);//loads title screen
    }

    //allows scrolling 
    public void Options()
    {
        Time.timeScale=1f;
    }
    //

    //Apply makes sure game is still paused
    public void apply()
    {
        Time.timeScale = 0f;
    }
}
