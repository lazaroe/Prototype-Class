using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

	[SerializeField]
	GameObject bullet;
	public GameObject target;
	public GameObject Flash;
	public int FlashTime = 2;

	public float fireRate = 2;
	public float nextFire;

	void OnTriggerStay () 
	{
	CheckIfTimeToFire();
	}

	void Start () 
	{
	nextFire = Time.time;
	target = GameObject.FindWithTag("Player");
	}
	
	void Update () 
	{
	//transform.right = target.position - transform.position;	......works great for 2D
	//transform.LookAt(target); //.....works great for 3D
	 Vector3 targetPostition = new Vector3( target.transform.position.x, this.transform.position.y, target.transform.position.z ) ;
 	this.transform.LookAt( targetPostition ) ; //Rotate just for y
	
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) {
			Instantiate (bullet, transform.position, Quaternion.identity);
			nextFire = Time.time + fireRate;
			GameObject clone = (GameObject) Instantiate (Flash, transform.position, Quaternion.identity);
			Destroy (clone, FlashTime);
		}
		
	}

}

