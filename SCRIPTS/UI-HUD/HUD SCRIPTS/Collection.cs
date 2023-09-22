using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Collection : MonoBehaviour
{
    public static float Count;
    [SerializeField]public TMP_Text CountText;
  
    public void Start()
    {
        Count = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Count++;
            CountText.text = Count.ToString("0");
            HighScore.ScorePoints += 5;
            Destroy(gameObject);
           
        }

    }

}
