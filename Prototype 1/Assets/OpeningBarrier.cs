using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningBarrier : MonoBehaviour {

    Renderer ColorBarrier;
    public GameObject Barrier;

     void Start()
    {
        ColorBarrier = GetComponent<Renderer>();
    }
      void OnMouseDown()
    {
       ColorBarrier.material.color = Color.red;
       Barrier.SetActive(false);
    }
}
