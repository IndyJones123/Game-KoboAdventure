using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectTrigger : MonoBehaviour
{
    [SerializeField]

    private bool pickUpAllowed;

	// Use this for initialization
	private void Start () {
        
	}
	
	// Update is called once per frame
	private void Update () {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            pickUpAllowed = true;
        }        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        Destroy(gameObject);
    }
}
