using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emiteffect : MonoBehaviour {

	public GameObject FireEffect;
	void Update ()
	{
		 Instantiate(FireEffect, transform.position, transform.rotation);	
	}
}
