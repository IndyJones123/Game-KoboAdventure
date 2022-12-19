using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilus : MonoBehaviour
{
	[SerializeField]
	GameObject bullet;

    public bool tembak;
	public bool damage;

	// Use this for initialization
	public void Check(bool damage) {
		tembak = damage;
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfTimeToFire ();
	}

	void CheckIfTimeToFire()
	{
		if (tembak==true) {
			Instantiate (bullet, transform.position, Quaternion.identity);
			tembak=false;
		}
		
	}
}
