using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TitleScreen : MonoBehaviour
{
    Collection Ammo_Hud;
    private void Start()
    {
        Collection.Count = 0;
        HighScore.ScorePoints = 0;
        Time.timeScale = 1f;
    }
    public void PlayGame()
    {
         //makes sure after player dies the health is back up 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
