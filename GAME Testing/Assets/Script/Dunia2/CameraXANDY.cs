using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraXANDY : MonoBehaviour
{
    public Transform target;
 
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y+2, -10);
    }
}
