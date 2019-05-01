using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningBarrier : MonoBehaviour {

    public Renderer ColorBarrier1;
    public GameObject Barrier1;
    public GameObject OverRide;
    public int OverRideTime = 2;
    AudioManager audioManager;

     void Start()
    {
        ColorBarrier1 = gameObject.GetComponent<Renderer>();
        audioManager = AudioManager.instance;
		    if (audioManager == null)
		    {
		    	Debug.LogError("FREAK OUT! No AudioManager found in the scene.");
		    }
    }
      void OnMouseDown()
    {
       audioManager.PlaySound("Electricity");
       ColorBarrier1.material.color = Color.red;
       GameObject clone = (GameObject) Instantiate (OverRide, transform.position, Quaternion.identity);
		   Destroy (clone, OverRideTime);
       Barrier1.SetActive(true);
    }
}
