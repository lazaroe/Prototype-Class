using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingMissile : MonoBehaviour {

	public GameObject target;
	public GameObject ExplosionEffect;
	public float explosionEffectTime = 1;

	public float speed = 5f;
	public float rotateSpeed = 200f;

	private Rigidbody2D rb;

	
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
		target = GameObject.FindWithTag("Player");

	}
	
	void FixedUpdate () {
		Vector2 direction = (Vector2)target.transform.position - rb.position;

		direction.Normalize();

		float rotateAmount = Vector3.Cross(direction, transform.up).z;

		rb.angularVelocity = -rotateAmount * rotateSpeed;

		rb.velocity = transform.up * speed;
	}

	void OnTriggerEnter2D ()
	{
		GameObject clone = (GameObject) Instantiate (ExplosionEffect, transform.position, Quaternion.identity);
		Destroy (clone, explosionEffectTime);
		Destroy(gameObject);
	}
}


	//works only for 2D