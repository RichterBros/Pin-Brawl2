using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneBallSensor : MonoBehaviour {

void OnTriggerEnter(Collider col)
  {
    GameManager.ballKillTrigger1 = 1;

  }
void OnCollisionEnter(Collision col)
{
//GameManager.playerScoring = 1;
Debug.Log("player one ball collision");
}



  void OnDrawGizmos()
  {
      Gizmos.color = new Color32(255,0,0, 125);
      Gizmos.matrix = transform.localToWorldMatrix;
      Gizmos.DrawCube(Vector3.zero, Vector3.one);
  }


	
}
