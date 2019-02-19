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
	//transform.right = target.position - transform.position;	......works great for 2D
	//transform.LookAt(target); //.....works great for 3D
	 Vector3 targetPostition = new Vector3( target.position.x, this.transform.position.y, target.position.z ) ;
 	this.transform.LookAt( targetPostition ) ; //Rotate just for y
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) {
			Instantiate (bullet, transform.position, Quaternion.identity);
			nextFire = Time.time + fireRate;
		}
		
	}

}

