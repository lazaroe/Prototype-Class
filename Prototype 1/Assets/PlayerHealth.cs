using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public GameObject[] HurtfulThings;

		void OnCollisionEnter (Collision HurtfulThings)
    {  
        {
            Destroy(HurtfulThings.gameObject);
        }
    }
}
