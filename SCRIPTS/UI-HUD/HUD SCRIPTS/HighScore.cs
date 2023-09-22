using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HighScore : MonoBehaviour
{
    [SerializeField] TMP_Text ScoreCount;//stores points collected
    [SerializeField] TMP_Text OveralScore;//high score in total after player finsihes leve;
    public static float ScorePoints;

    // Update is called once per frame
    void Update()
    {
        //when player reaches the goal they will get a high score. 
        ScoreCount.text = ScorePoints.ToString("0");
        OveralScore.text = ScorePoints.ToString("0");
    }
}