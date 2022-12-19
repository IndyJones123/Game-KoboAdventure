using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

	[SerializeField]
	GameObject bullet;

	float fireRate;
	float nextFire;

	// Use this for initialization
	void Start () {
		fireRate = 2.5f;
		nextFire = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfTimeToFire ();
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) {
			Instantiate (bullet, transform.position, Quaternion.identity);
			nextFire = Time.time + fireRate;
		}
		
	}

}
