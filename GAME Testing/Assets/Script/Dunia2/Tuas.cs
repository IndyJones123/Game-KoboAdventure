using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuas : MonoBehaviour
{
    [SerializeField]
    public GameObject PenyanggaAktif;
    public GameObject TuasAktif;
    public GameObject deleteobject;
    public GameObject deleteobject2;

    private bool pickUpAllowed;

	// Use this for initialization
	private void Start () {
        TuasAktif.gameObject.SetActive(false);
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
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        PenyanggaAktif.gameObject.SetActive(true);
        TuasAktif.gameObject.SetActive(true);
        Destroy(deleteobject2);
        Destroy(gameObject);
        
    }
}
