using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {

	float moveSpeed = 100f;

	Rigidbody2D rb;

	EnemySpawner target;
	Vector2 moveDirection;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		target = GameObject.FindObjectOfType<EnemySpawner>();
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
		Destroy (gameObject, 3f);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.name.Equals ("Boss")) {
			Debug.Log ("Hit!");
			Destroy (gameObject);
		}
	}

}
