using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDiculik2 : MonoBehaviour
{
    public Transform target;
    private bool culik;
    // Start is called before the first frame update
    void Start()
    {
        culik = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(culik==true)
        {
            transform.position = new Vector3(target.position.x+2, target.position.y+2, 0);
        }  
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Penculik2")
            culik=true;
    }
}
