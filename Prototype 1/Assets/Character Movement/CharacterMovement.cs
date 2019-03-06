using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour {
        
        private CharacterController controller;
        public MovePattern Current;
        public MovePattern Fast;
        public MovePattern Back;
        public GameObject FastParticles;
        public float PowerUpTime;
        
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        Current = Back;
        FastParticles.SetActive(false);
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
        other.gameObject.SetActive(false);
		Current = Fast;
        StartCoroutine(Duration());
        FastParticles.SetActive(true);
    }
}
    public IEnumerator Duration ()
    {
        yield return new WaitForSeconds (PowerUpTime);
        Current = Back;
        FastParticles.SetActive(false);
    }

}