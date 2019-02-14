using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningBarrier : MonoBehaviour {

    Renderer ColorBarrier;
    public GameObject Barrier;
    public GameObject OverRide;

     void Start()
    {
        ColorBarrier = GetComponent<Renderer>();
    }
      void OnMouseDown()
    {
       ColorBarrier.material.color = Color.red;
       Instantiate(OverRide, transform.position, transform.rotation);
       Barrier.SetActive(false);
    }
}
