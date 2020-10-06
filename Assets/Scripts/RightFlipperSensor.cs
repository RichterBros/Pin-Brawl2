using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipperSensor : MonoBehaviour {

void OnCollisionEnter(Collision col)
  {
    
  GameManager.playerOne = 2;
  }

}


