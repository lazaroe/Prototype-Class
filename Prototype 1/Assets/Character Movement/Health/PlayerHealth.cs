using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    
    public GameObject heart1, heart2, heart3, heart4;
    //public GameObject Fire;
    //public int FireTime;
    public static int health;
    public GameObject Player;
    public GameObject DeadBody;
    public GameObject Smoke;
    AudioManager audioManager;
    public GameObject HideDetails;
    public GameObject ExplosionEffect;
    public float explosionEffectTime = 1;

    void Start ()
    {
        audioManager = AudioManager.instance;
		if (audioManager == null)
		{
			Debug.LogError("FREAK OUT! No AudioManager found in the scene.");
		}

        health = 4;
        heart1.gameObject.SetActive (true);
        heart2.gameObject.SetActive (true);
        heart3.gameObject.SetActive (true);
        heart4.gameObject.SetActive (true);
    }
    void Update ()
    {
        if (health > 4)
        health = 4;

        switch (health)
        {
            case 4:
            heart1.gameObject.SetActive (true);
            heart2.gameObject.SetActive (true);
            heart3.gameObject.SetActive (true);
            heart4.gameObject.SetActive (true);
            Smoke.gameObject.SetActive (false);
            break;

            case 3:
            heart1.gameObject.SetActive (true);
            heart2.gameObject.SetActive (true);
            heart3.gameObject.SetActive (true);
            heart4.gameObject.SetActive (false);
            Smoke.gameObject.SetActive (false);
            
          
            break;
            case 2:
            audioManager.PlaySound("Alarm");
            heart1.gameObject.SetActive (true);
            heart2.gameObject.SetActive (true);
            heart3.gameObject.SetActive (false);
            heart4.gameObject.SetActive (false);
            Smoke.gameObject.SetActive (false);


            break;
            case 1:
        
            heart1.gameObject.SetActive (true);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (false);
            heart4.gameObject.SetActive (false);
            Smoke.gameObject.SetActive (true);
            
            
            break;
            case 0:
            heart1.gameObject.SetActive (false);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (false);
            heart4.gameObject.SetActive (false);
            Player.gameObject.SetActive(false);
            DeadBody.gameObject.SetActive(true);
            GameObject clone = (GameObject) Instantiate (ExplosionEffect, transform.position, Quaternion.identity);
		    Destroy (clone, explosionEffectTime);
            Time.timeScale = .2f;
            audioManager.PlaySound("SuperExplotion");
            HideDetails.gameObject.SetActive(false);
            break;
        }
    }
}
//GameObject clone = (GameObject) Instantiate (Fire, transform.position, Quaternion.identity);
//Destroy (clone, FireTime);