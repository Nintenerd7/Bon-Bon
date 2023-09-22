using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    float RecentTime = 0f;
    float TimeCount = 400;

    [SerializeField] TMP_Text CountDown;

    void Start()
    {
        RecentTime = TimeCount;
    }

    void Update()
    {
        RecentTime -= 1 * Time.deltaTime;
        CountDown.text = RecentTime.ToString("0");//timer

        //if timer goes to zero
        if (RecentTime <= 0)
        {
            RecentTime = 0;//time says at zero.
            SceneManager.LoadScene(2);
        }
    }
 
}
