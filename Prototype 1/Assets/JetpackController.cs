using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetpackController : MonoBehaviour {

	public float jetpackCooldown = 3f; 
    void Start()
    {
        Debug.Log("Jetpack");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            jetpackCooldown -= Time.deltaTime;
            Debug.Log(jetpackCooldown);

            if (jetpackCooldown <= 0)
            {
                Debug.Log("end");

                jetpackCooldown = 3f;
                gameObject.SetActive(false);
            }
        }
    }
}

//the jetpack goes away after a certain amount of time