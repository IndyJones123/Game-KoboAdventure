using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_pull : MonoBehaviour
{
    public float defaultMass;
    public float imovableMass;
    public bool beingPushed;
    float xPos;
    
    public Vector3 lastPost;

    public int mode;
    public int colliding;
    // Start is called before the first frame update
    void Start()
    {
        xPos = transform.position.x;
        lastPost =transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(mode == 0)
        {
            if(beingPushed == false) {
                transform.position = new Vector3 (xPos, transform.position.y);
            }else
                xPos = transform.position.x;            
        }else if(mode == 1)
        {
            if(beingPushed == false)
            {
                GetComponent<Rigidbody2D> ().mass=imovableMass;
            }else
            {
                GetComponent<Rigidbody2D> ().mass=defaultMass;
            //  GetComponent<Rigidbody2D> ().isKinematic = false;
            }
        }
    }
}
