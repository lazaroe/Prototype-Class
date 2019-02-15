using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

	[SerializeField]
	GameObject bullet;
	public Transform target;

	public float fireRate = 2;
	public float nextFire;

	void Start () {
	nextFire = Time.time;
	}
	
	void Update () 
	{
	CheckIfTimeToFire ();
	transform.right = target.position - transform.position;	
	//transform.LookAt(target); .....works great for 3D
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) {
			Instantiate (bullet, transform.position, Quaternion.identity);
			nextFire = Time.time + fireRate;
		}
		
	}

}

