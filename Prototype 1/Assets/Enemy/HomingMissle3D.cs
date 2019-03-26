using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMissle3D : MonoBehaviour {

	public Transform rocketTarget;
	public Rigidbody rocketRigidbody;
	public float turnR;
	public float rocketVelocity;

	private void FixedUpdate()
	{
		rocketRigidbody.velocity = transform.forward * rocketVelocity;
		var rocketTargetRotation = Quaternion.LookRotation(rocketTarget.position - transform.position);
		rocketRigidbody.MoveRotation (Quaternion.RotateTowards(transform.rotation, rocketTargetRotation, turnR));
	}
}
