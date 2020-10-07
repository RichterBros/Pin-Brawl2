using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipperSensor : MonoBehaviour {

void OnCollisionEnter(Collision col)
  {
    
  GameManager.playerScoring = 1;
  }

}
