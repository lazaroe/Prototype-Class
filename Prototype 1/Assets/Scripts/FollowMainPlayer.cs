using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMainPlayer : MonoBehaviour {

	public GameObject Target;
	public GameObject DeathMenu;
	void Update () 
	{
		transform.position = Target.transform.position;
	}
	void Start()
	{
		StartCoroutine(DeathDelay(DeathMenu, .5f));
		if (Target.gameObject == false)
		{
			DeathMenu.gameObject.SetActive (true);
		}
	}

	IEnumerator DeathDelay( GameObject DeathMenu, float delay )
     {
         yield return new WaitForSeconds(.5f);
         DeathMenu.gameObject.SetActive (true);
     }
}
