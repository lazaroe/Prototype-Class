using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHeart : MonoBehaviour {

	void OnTriggerEnter (Collider col)
	{
		PlayerHealth.health += 1;
		Destroy(gameObject);
	}

}
