using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
	public float value;
	
	public virtual float Value
	{
		get {return value;}
	}
}
