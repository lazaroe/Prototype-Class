using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public int amount = 1;
	AudioManager audioManager;

	void Start()
	{
		audioManager = AudioManager.instance;
		if (audioManager == null)
		{
			Debug.LogError("FREAK OUT! No AudioManager found in the scene.");
		}
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag.Equals ("Player"))
		{
		PlayerHealth.health -= amount;
		audioManager.PlaySound("Scratch");
		}
	}
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag.Equals ("Player"))
		{
		PlayerHealth.health = amount;
		audioManager.PlaySound("Scratch");
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
