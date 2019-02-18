using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {
    Light siren;
    public float intervalTime = 0.1f;
    float intervalTimer = 0f;
    bool isOn;
 
    void Start()
    {
        siren = gameObject.GetComponent<Light>();
    }
 
    void Update()
    {
 
        intervalTimer += Time.deltaTime;
 
        if (intervalTimer > intervalTime)
        {
            isOn = !isOn;
            if (isOn)
            {
                GetComponent<Light>().intensity = 1.0f;
            }
            else
            {
                GetComponent<Light>().intensity = 0.0f;
            }
 
            intervalTimer = 0f;
        }
    }

}
