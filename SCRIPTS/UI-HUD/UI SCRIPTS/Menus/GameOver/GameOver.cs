using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
 public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Title()
    {
        SceneManager.LoadScene(0);
        
    }
}
