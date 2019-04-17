using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public int amount = 1;
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag.Equals ("Player"))
		{
		PlayerHealth.health -= amount;
		}
	}
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag.Equals ("Player"))
		{
		PlayerHealth.health = amount;
		}
	}
	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag.Equals ("Player"))
		{
		PlayerHealth.health -= amount;
		}
	}
}
