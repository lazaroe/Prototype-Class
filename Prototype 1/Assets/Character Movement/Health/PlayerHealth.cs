using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    
    public GameObject heart1, heart2, heart3, gameOver;
    //public GameObject Fire;
    //public int FireTime;
    public static int health;
    public GameObject Player;
    public GameObject Smoke;

    void Start ()
    {
        health = 3;
        heart1.gameObject.SetActive (true);
        heart2.gameObject.SetActive (true);
        heart3.gameObject.SetActive (true);
        gameOver.gameObject.SetActive (false);
    }
    void Update ()
    {
        if (health > 3)
        health = 3;

        switch (health)
        {
            case 3:
            heart1.gameObject.SetActive (true);
            heart2.gameObject.SetActive (true);
            heart3.gameObject.SetActive (true);
          
            break;
            case 2:
            heart1.gameObject.SetActive (true);
            heart2.gameObject.SetActive (true);
            heart3.gameObject.SetActive (false);

            break;
            case 1:
            heart1.gameObject.SetActive (true);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (false);
            Smoke.gameObject.SetActive (true);
            
            break;
            case 0:
            heart1.gameObject.SetActive (false);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (false);
            gameOver.gameObject.SetActive (true);
            Player.gameObject.SetActive(false);
            Time.timeScale = 0;
            break;
        }
     
    }
}
//GameObject clone = (GameObject) Instantiate (Fire, transform.position, Quaternion.identity);
//Destroy (clone, FireTime);