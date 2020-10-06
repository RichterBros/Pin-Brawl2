using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseArea2 : MonoBehaviour
{

  void OnTriggerEnter(Collider col)
  {
    Destroy(col.gameObject);
    GameManager.instance.CreateNewBall2();

  }

}
