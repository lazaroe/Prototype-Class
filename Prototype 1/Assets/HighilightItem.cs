using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighilightItem : MonoBehaviour {

	public bool InRange;
	public GameObject Highlighter;

private void OnTriggerEnter(Collider obj)
{
	InRange = true;
	Highlighter.SetActive(true);
}
private void OnTriggerExit(Collider obj)
{
	if (obj.CompareTag("Player"))
	{
		InRange = false;
		Highlighter.SetActive(false);
	}
}
}
