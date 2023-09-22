using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParrallaxEffect : MonoBehaviour
{
    private float startpos, length;
    public GameObject cam;
    [SerializeField]private float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;    
    }

    // Update is called once per frame
    void FixedUpdate()// allows paralax background to run smootly without jitter 
    {
        float Temp = (cam.transform.position.x * (0.5f-parallaxEffect));
        float Distance = (cam.transform.position.x *parallaxEffect);
        transform.position = new Vector3(startpos + Distance, transform.position.y, transform.position.z);
        
       if(Temp > startpos + length)
        {
            startpos += length;//shifts the sprite right 
        }
       else if (Temp < startpos - length)
        {
            startpos -= length;//shifts the sprite left 
        }
    }
    


}