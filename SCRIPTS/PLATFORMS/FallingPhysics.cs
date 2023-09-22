using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPhysics : MonoBehaviour
{
    // Start is called before the first frame update

    //rigidbody2D variables
    Rigidbody2D Platform;
    void Start()
    {
        Platform = GetComponent<Rigidbody2D>();
    }

    // when the player lands on the platform
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Bon-Bon"))
        {
            Invoke("FallDown", 0.5f);
            Destroy(gameObject, 2f);
        }
    } 

    void FallDown()
    {
        Platform.isKinematic = false;
    }

}
