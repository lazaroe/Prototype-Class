using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHeart : MonoBehaviour {

	AudioManager audioManager;
	void Start ()
	{
		audioManager = AudioManager.instance;
		if (audioManager == null)
		{
			Debug.LogError("FREAK OUT! No AudioManager found in the scene.");
		}
	}

	void OnTriggerEnter (Collider col)
	{
		audioManager.PlaySound("HeartPickUp");
		PlayerHealth.health += 1;
		Destroy(gameObject);
	}

}
