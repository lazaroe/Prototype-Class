using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour {
        
        private CharacterController controller;
        public MovePattern Current;
        public MovePattern Fast;
        public MovePattern Back;

        public MovePattern Slow;
        public GameObject FastParticles;
        public float PowerUpTime;
        public float SlowDownTime;
        AudioManager audioManager;
        
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        Current = Back;
        FastParticles.SetActive(false);
        audioManager = AudioManager.instance;
		if (audioManager == null)
		{
			Debug.LogError("FREAK OUT! No AudioManager found in the scene.");
		}
    }

    void Update() 
    {
            Current.Invoke(controller, transform);
            
    }
   void OnTriggerEnter
    (Collider other)
{
    if (other.gameObject.CompareTag("PickUp"))
    {
        audioManager.PlaySound("PowerUp");
        other.gameObject.SetActive(false);
		Current = Fast;
        StartCoroutine(Duration());
        FastParticles.SetActive(true);
    }
     if (other.gameObject.CompareTag("BlackHole"))
    {
        Current = Slow;
        StartCoroutine(BlackHoleDuration());

    }
}
    public IEnumerator Duration ()
    {
        yield return new WaitForSeconds (PowerUpTime);
        Current = Back;
        FastParticles.SetActive(false);
    }
    public IEnumerator BlackHoleDuration ()
    {
        yield return new WaitForSeconds (SlowDownTime);
        Current = Back;
    }

}