using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManag : MonoBehaviour {

	public static AudioClip playerSound, Alarm, explotionsound, missilesound;
	static AudioSource audioSrc;

	void Start ()
	{
		playerSound = Resources.Load<AudioClip> ("Player");
		Alarm = Resources.Load<AudioClip> ("Alarm");
		explotionsound = Resources.Load<AudioClip> ("Explotion");
		missilesound = Resources.Load<AudioClip> ("Missile");

		audioSrc = GetComponent<AudioSource>();
	}
	public static void PlaySound (string clip)
	{
		switch (clip)
		{
			case "Alarm":
			audioSrc.PlayOneShot (Alarm);
			break;
		}
	}
}

//place this in the scrip where the sound may be
//AudioManag.PlaySound ("Fire");