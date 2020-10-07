using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseArea : MonoBehaviour
{

  void OnTriggerEnter(Collider col)
  {
    
  
  //  if(GameManager.ballKillTrigger1 == 1)
  // {


  // Destroy(col.gameObject);
  //   GameManager.instance.CreateNewBall();

  // }
    if(col.gameObject.CompareTag("ball1"))
     {
     Destroy(col.gameObject);
     
     GameManager.instance.CreateNewBall();
     }
      
    if(col.gameObject.CompareTag("ball2"))
     {
     ScoreManager1.playerTwoScore += 5000;
     GameManager.
     Destroy(col.gameObject);
     GameManager.instance.CreateNewBall2();
     
     
     }

}
}



  // if(col.transform.tag == "Ball1")
  //   {
  //     Destroy(col.gameObject);
  //     GameManager.instance.CreateNewBallTest();
  //     Debug.Log("test");
  //     }