using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Shoot : MonoBehaviour
{
    public Transform Fire_Point;//the position of where the bullet is firing 
    public GameObject Bullet_Prefab;//The game object that spawns as the bullet 
    player_movement Orientation;//Object orientation for certain variables
    public TMP_Text CountText;//updates Ammo UI when bullet is fired. 

    private void Start()
    {
        Orientation = GetComponent<player_movement>();//orientation variable now has access to specific player movement logic 
    }
    private void Update()
    {
     if(!Pause.IsPaused)//if the game is not paused 
        {
            Use_Weapon();//Player can use their weapon 
        }
        else//if it is paused. 
        {
            Dont_Shoot();//player cannot shoot 
        }
    }
    void Use_Weapon()//allows player to use their weapon with the left click 
    {
        if (Input.GetMouseButtonDown(0))//if player presses left click 
        {
            Shoot_Bullet();//call shoot bullet method 
        }
    }
    void Shoot_Bullet()//this method contains the logic that fires the bullet. 
    {
        if(Collection.Count > 0)//if collection count is more than zero
        {
            Update_HUD();//call update hud method 
            Bullet_Prefab.SetActive(true);//prefab is visible 
            float angle = Orientation.isFacingRight ? 0f : 180f;//calculates player direction
            Instantiate(Bullet_Prefab, Fire_Point.position, Quaternion.Euler(new Vector3(0f, 0f, angle)));//instantiates bullet fire 
        }
    }

    void Dont_Shoot()//this method is for when the player is not allowed to shoot bullets 
    {
        Bullet_Prefab.SetActive(false);//bullet is invisible 
    }

    void Update_HUD()//this updates the hud when the player uses their weapon 
    {
        Collection.Count--;//count is taken away by 1
        CountText.text = Collection.Count.ToString("0");//appears on text 
        if (Collection.Count == 0)//if the hud count is equal to zero 
        {
            Collection.Count = 0;//count is equal to zero 
            Dont_Shoot();//call don't shoot method
        }
    }
}
