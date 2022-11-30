using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collider) {
        Player player = collider.GetComponent<Player>();
        if (player != null) {
            // Player hit Spikes
            Player.Die_Static();
        }
    }

}
