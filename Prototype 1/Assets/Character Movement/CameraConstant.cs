using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConstant : MonoBehaviour {

	public Vector3 PlayerLocation;
    public GameObject Player;
    public Vector3 EnemyLocation;
    public GameObject Enemy;
    private CameraMovement EnemyMove;
    public CharacterMovement PlayerSpeed;
    

    private void Start()
    {
       EnemyMove = GetComponent<CameraMovement>();
    }

    private void Update()
    {
        PlayerLocation = Player.transform.position;
        EnemyLocation = Enemy.transform.position;
       
        {
            if (PlayerLocation.x < EnemyLocation.x)

            {
            
                EnemyMove.characterSpeed = 5;
            }
            else
            {
                if (PlayerLocation.x == EnemyLocation.x)
                {
                    EnemyMove.characterSpeed = 19;
                }
                if (PlayerLocation.x > EnemyLocation.x)
                {
                    EnemyMove.characterSpeed = 19;
                }
            }

        }
    }

}
