using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseArea2 : MonoBehaviour
{

  void OnTriggerEnter(Collider col)
  {
    if(col.gameObject.CompareTag("ball1"))
     {
     ScoreManager1.playerOneScore += 5000;
     Destroy(col.gameObject);
     GameManager.instance.CreateNewBall();
     }
      
    if(col.gameObject.CompareTag("ball2"))
     {
     Destroy(col.gameObject);
     GameManager.instance.CreateNewBall2();
     }

  }

}



// if(!GameObject.FindWithTag("ball1"))
//     {
//       Destroy(col.gameObject);
//       GameManager.instance.CreateNewBall2();
//       Debug.Log("test2");
//       }
//       else 
//       {
//       Destroy(col.gameObject);
//       GameManager.instance.CreateNewBallTest();
//       Debug.Log("test1");
//       }