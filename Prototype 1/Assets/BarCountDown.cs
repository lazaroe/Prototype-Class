using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarCountDown : MonoBehaviour {

	Image TimerBar;
	public float maxTime = 5f;
	float timeLeft;
	

	void Start ()
		{
			TimerBar = GetComponent<Image>();
			//timeLeft = maxTime;
			timeLeft = 0f;
		}
	void Update ()
	{
		if (timeLeft >= 0)		//if (timeLeft > 0)
		{
			//timeLeft -= Time.deltaTime;
			timeLeft += Time.deltaTime;
			//TimerBar.fillAmount = timeLeft / maxTime;
			TimerBar.fillAmount = timeLeft / maxTime;
		}
		else
		{
			print ("Winning Stuff goes here");
		}
	}
}
//Notes show it disapearing
