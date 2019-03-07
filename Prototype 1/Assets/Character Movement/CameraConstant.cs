using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConstant : MonoBehaviour {

	public Vector3 PlayerLocation;
    public GameObject Player;
    public Vector3 CameraLocation;
	private int movingSpeed = 10;

	public Camera Cam;

    private void Start()
    {
       // EnemyMove = GetComponent<EnemyMovement>();
    }

    private void Update()
    {
		CameraLocation = Cam.transform.position;
        PlayerLocation = Player.transform.position;
       // if (IsMovingBool.EnemyisMoving == true)
        {
            if (PlayerLocation.x < CameraLocation.x)

            {
                print("y");
            
                //EnemyMove.characterSpeed = 0;
            }
            else
            {
      		transform.position += Vector3.right * Time.deltaTime * movingSpeed;
            }

        }
    }

}
