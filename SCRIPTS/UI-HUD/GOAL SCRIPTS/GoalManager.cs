using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GoalManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GoalUI;
    public void ScoreBoard()
    {
        Time.timeScale = 0;
        Pause.IsPaused = true;
        GoalUI.SetActive(true);
    }

    public void Next()
    {
        SceneManager.LoadScene(3);//thank you screen 
        Pause.IsPaused = false;
        GoalUI.SetActive(false);
    }
}
