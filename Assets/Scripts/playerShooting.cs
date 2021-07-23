using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour {
	public Transform projectilePrefab;			// Stores the prefab that the player shoots
	public float forceMultiplier = 5000.0f;		// how much force is applied to the projectile

	// Update function runs once per frame refresh
	void Update () {
		// Test if primary button is pressed
		if (Input.GetMouseButtonDown(0)) {
			
			
			Transform projectile = Instantiate(projectilePrefab, transform.Find("playerShootSpawn").transform.position, Quaternion.identity);
			projectile.gameObject.tag = "projectile";
			projectile.transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward, transform.up);
			projectile.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * forceMultiplier);
		}
	}
}
