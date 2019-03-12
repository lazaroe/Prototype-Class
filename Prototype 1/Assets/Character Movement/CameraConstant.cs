using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConstant : MonoBehaviour {

	public Vector3 PlayerLocation;
    public GameObject Player;
    public Vector3 EnemyLocation;
    public GameObject Enemy;
    //private EnemyMovement EnemyMove;
    //public EnemyMoveBool IsMovingBool;

    private void Start()
    {
       //EnemyMove = GetComponent<EnemyMovement>();
    }

    private void Update()
    {
        PlayerLocation = Player.transform.position;
        EnemyLocation = Enemy.transform.position;
       // if (IsMovingBool.EnemyisMoving == true)
        {
            if (PlayerLocation.x < EnemyLocation.x)

            {
                print("y");
            
               // EnemyMove.characterSpeed = 0;
            }
            else
            {
               // EnemyMove.characterSpeed = 6;
            }

        }
    }

}
