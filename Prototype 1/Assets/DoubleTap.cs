 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoubleTap : MonoBehaviour 
{
	public float ClickCoolDownTime = 2;
	public int ClickCountMax = 2;
	[SerializeField] private int clickCount = 0;
	private Coroutine coroutine;
	public UnityEvent Event;

	private IEnumerator Start()
	{
		yield return new WaitForSeconds(ClickCoolDownTime);
		clickCount = 0;
		coroutine = null;
	}
	

	private void OnMouseDown()
	{
		if (clickCount == ClickCountMax)
		{
			Event.Invoke();					//DO WORK HERE
		}
		if (clickCount < ClickCountMax)
		{
			print("DO THE WORK HERE");
			clickCount++;
		}
		else
		{
			if (coroutine == null)
			{
				coroutine = StartCoroutine(Start());
			}
		}
	}

	

	
}
