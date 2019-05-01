using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {        
        private CharacterController controller;
        public MovePattern Pattern;
        
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update() {
            Pattern.Invoke(controller, transform);
        }
   void OnTriggerEnter
    (Collider other)
{
    if (other.gameObject.CompareTag("PickUp"))
    {
        other.gameObject.SetActive(false);
    }
}
}