using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float moveSpeed = 7f;

	//Rigidbody2D rb;  //for 2D
	Rigidbody rb;

	CharacterMovement target;
	//Vector2 moveDirection;		//for2D
	Vector3 moveDirection;
	void Start () {
		rb = GetComponent<Rigidbody> ();			//Rigidbody2D for 2D objects
		target = GameObject.FindObjectOfType<CharacterMovement>();
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector3 (moveDirection.x, moveDirection.y, moveDirection.z);					//Vector2 & Only move on (moveDirection.x, moveDirection.y)
		Destroy (gameObject, 3f);
	}

	void OnTriggerEnter (Collider col)				//void OnTriggerEnter2D (Collider2D col) for 2D
	{
		if (col.gameObject.tag.Equals ("Player")) {
			Debug.Log ("Hit!");
			Destroy (gameObject);
		}
	}

}
