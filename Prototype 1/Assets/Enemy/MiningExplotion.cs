using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningExplotion : MonoBehaviour {

	public GameObject MiddlePiece;
	public GameObject TopPiece;
	public GameObject BottomPiece;
	public GameObject LeftPiece;
	public GameObject RightPiece;
    public GameObject ExplosionParticles;
	public int destroyTime;
    

	void OnMouseDown()
    {
    MiddlePiece.SetActive(false);
	TopPiece.SetActive(true);
    Instantiate(ExplosionParticles, transform.position, transform.rotation);
	if(TopPiece == true)
             {
                Destroy(TopPiece, destroyTime);
             }
	BottomPiece.SetActive(true);
	if(BottomPiece == true)
             {
                 Destroy(BottomPiece, destroyTime);

             }
	LeftPiece.SetActive(true);
	if(LeftPiece == true)
             {
                 Destroy(LeftPiece, destroyTime);

             }
	RightPiece.SetActive(true);
	if(RightPiece == true)
             {
                 Destroy(RightPiece, destroyTime);

             }
         }

 }
