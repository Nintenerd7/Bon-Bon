using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class LivesSystem : MonoBehaviour
{
    //FALL COLLISION VARIABLES 
    public GameObject Fall_Detector;//holder for the fall detector collider 
    private Vector3 Respawn_Point;//records the position for the respawn point 
    //LIVES SYSTEM VARIABLES
    int Live_Count;
    public TMP_Text Live_UI_Text;
    //OBJECT ORIENTATION VARIABLES 
    #region START AND UPDATE
    private void Start()
    {
        Respawn_Point = transform.position;//gets the player position.
        Live_Count = 3;
    }

    private void Update()
    {
        Fall_Detector.transform.position = new Vector2(transform.position.x, Fall_Detector.transform.position.y);
    }
    #endregion
    #region COLLISION TRIGGER 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FallDetector")
        {
            Death_From_Fall();//call death from fall method 
        }//if player falls off screen. 
         
    }
    #endregion
    #region METHODS 
    void Death_From_Fall()
    {
        //logic for taking a life by falling 
        transform.position = Respawn_Point;//player returns to the position they were 
        Take_Life();//call the Take life method 
    }

    void Take_Life()
    {
        //logic for how lives will be taken 
        Live_Count--;//takes 1 life away from the player 
        Live_UI_Text.text = Live_Count.ToString("0");//sets lives to display on text

        if (Live_Count == 0)//if the player has no lives 
            SceneManager.LoadScene(2);//loads Game Over screen. 

    }
    #endregion
}
