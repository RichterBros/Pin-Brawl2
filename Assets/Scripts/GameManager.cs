using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  
  public static GameManager instance;
  public static int playerScoring = 0;

  public static int ballKillTrigger1 = 0;

  // public static int playerOneScore = 0;

  // public static int playerTwoScore = 0;
  public static int startBallAmount = 3;

  public static int startBallAmount2 = 3;
  public static int currentBallAmount;

  public static int currentBallAmount2;

  //SPAWNBALL
  
  
  public GameObject ballPrefab;
  //public  GameObject ballTest;
  public GameObject ballPrefab2;
  public Transform spawnPoint;

  public Transform spawnPoint2;
  bool gameStarted;

  void Awake()
  {
    instance = this;
  }

  void Start()
  {
    ResetGame();
  //  ballTest = Resources.Load("ballTest") as GameObject;
  }
	
  void ResetGame()
  {
    currentBallAmount = startBallAmount;
    currentBallAmount2 = startBallAmount2;
    UiManager.instance.UpdateBallText(currentBallAmount);
    UiManager.instance.UpdateBallText2(currentBallAmount2);
    
    CreateNewBall();
    // //CreateNewBallTest();
     //currentBallAmount2 = startBallAmount2;
     CreateNewBall2();
  }





  public void CreateNewBall()
  {
    if(currentBallAmount>0)
    {
    
    Instantiate(ballPrefab,spawnPoint.position,Quaternion.identity);
    currentBallAmount--;
    UiManager.instance.UpdateBallText(currentBallAmount);
    }
    else
    {
        Debug.Log("GAME OVER PLAYER ONE");
    }
  
  }

  public void CreateNewBall2()
  {
    if(currentBallAmount2>0)
    {
    Instantiate(ballPrefab2,spawnPoint2.position,Quaternion.identity);
    currentBallAmount2--;
    UiManager.instance.UpdateBallText2(currentBallAmount2);
    }
      else
    {
        Debug.Log("GAME OVER PLAYER TWO");
    }
  
  }

//  public void CreateNewBallTest()
//   {
    
    
//     Instantiate(ballTest,spawnPoint.position,Quaternion.identity);
//     currentBallAmount--;
    
//   }
  
}
