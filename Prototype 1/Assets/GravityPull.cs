using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPull : MonoBehaviour {
     public GameObject attractedTo;
    public float strengthOfAttraction = 5.0f;
     
         void FixedUpdate ()
         {
                 Vector3 direction = attractedTo.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
         
         }
 }

/*
     public float pullRadius = 2;
     public float pullForce = 1;
 
     public void FixedUpdate() {
         foreach (Collider collider in Physics.OverlapSphere(transform.position, pullRadius) {
             // calculate direction from target to me
             Vector3 forceDirection = transform.position - collider.transform.position;
 
             // apply force on target towards me
             collider.rigidbody.AddForce(forceDirection.normalized * pullForce * Time.fixedDeltaTime);
         }
     }
 }
*/