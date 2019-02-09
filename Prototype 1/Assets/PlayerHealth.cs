using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public GameObject Player;


		void OnCollision2D (Collision col)
    {  
        {
            Player.SetActive(false);
        }
    }
}
