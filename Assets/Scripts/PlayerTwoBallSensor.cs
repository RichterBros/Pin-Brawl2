using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoBallSensor : MonoBehaviour {

void OnCollisionEnter(Collision col)
{
//GameManager.playerScoring = 1;
Debug.Log("player two ball collision");
}


//  void OnTriggerEnter(Collider col)
//   {

//   }

  void OnDrawGizmos()
  {
      Gizmos.color = new Color32(0,0,255, 125);
      Gizmos.matrix = transform.localToWorldMatrix;
      Gizmos.DrawCube(Vector3.zero, Vector3.one);
  }

}
