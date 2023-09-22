using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_movement : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    public Rigidbody2D rb;
    public Animator Anim;
    public static float mx;
    public bool IsGrounded = true;
   
    // projectile aim
    [HideInInspector] public bool isFacingRight = true;
    //

    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update

    void Start()
    {
        Time.timeScale = 1f;//game is not frozen
        Anim = GetComponent<Animator>();//gets animation components from the animator scripts
        _rigidbody = GetComponent<Rigidbody2D>();//gets rigidbody component 
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();//Move player with A and D 
        Jump();//Player can jump with the space bar 
        
    }
    //fixed update
    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * MovementSpeed, rb.velocity.y);
        rb.velocity = movement;
    }
    //
    #region PLAYER FUNCTIONS 
    void MovePlayer()
    {
        //player movement 
        mx = Input.GetAxis("Horizontal");//player is only moving with the X axis 

        if (mx > 0)//if the player is facing right 
        {
            Move_Right();//player begins moving right 
        }
        else if (mx < 0)//if the player is facing left 
        {
            Move_Left();//player begins moving left
        }
        else
        {
            Idle();//player is now in idle mode 
        }
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector3(0, JumpForce), ForceMode2D.Impulse);
            IsGrounded = false;
            //jump sound 
            Anim.SetBool("IsJumping", true);
        }
        else
        {
         IsGrounded = true;
         Anim.SetBool("IsJumping", false);
        }
    }
    #endregion
    #region idle function 
    void Idle()
    {
        Anim.SetBool("IsRunning", false);
        Anim.SetBool("CanShoot", false);
    }
    #endregion
    #region direction functions 
    void Move_Right()
    {
        Anim.SetBool("IsRunning", true);//player animation starts 
        transform.localScale = new Vector3(1.4331f, 1.4331f, 1.4331f);//turns right
        isFacingRight = true;//player is facing right 
        IsGrounded = true;
    }

    void Move_Left()
    {
        Anim.SetBool("IsRunning", true);//player animation starts 
        transform.localScale = new Vector3(-1.4331f, 1.4331f, -1.4331f);//turns right
        isFacingRight = false;//player is facing left 
        IsGrounded = true;
    }
    #endregion

}
