using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour {
        
        private CharacterController controller;
        public MovePattern Current;
        public MovePattern Fast;
        public MovePattern Back;
        public float PowerUpTime;
        
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        Current = Back;
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
    }
}
    public IEnumerator Duration ()
    {
        yield return new WaitForSeconds (PowerUpTime);
        Current = Back;
    }

}