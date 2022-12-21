using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform movePoint;
    private bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.OpenDoorEvent += OpenDoor;
    }

    // Update is called once per frame
    void Update()
    {
        if(open == true)
        {
            transform.position = Vector3.MoveTowards(transform.position,movePoint.position,10*Time.deltaTime);
        }
    }

    private void OpenDoor()
    {
        open = true;
    }
    private void OnDisable()
    {
        EventManager.OpenDoorEvent -= OpenDoor;
    }
}
