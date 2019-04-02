using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour {

	public GameObject blackHole;
	public int Speed;
	
	
	void Update () 
	{
		OrbitAround();
	}

	void OrbitAround()
	{
		transform.RotateAround (blackHole.transform.position, Vector3.forward, Speed * Time.deltaTime);
	}

}
