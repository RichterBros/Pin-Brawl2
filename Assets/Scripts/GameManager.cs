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
  //UiManager.instance.playerOneWins(false);
    ResetGame();
  }
	
  public void ResetGame()
  {
    currentBallAmount = startBallAmount;
    currentBallAmount2 = startBallAmount2;
    UiManager.instance.UpdateBallText(currentBallAmount);
    UiManager.instance.UpdateBallText2(currentBallAmount2);
    ScoreManager1.instance.ResetScore();
    UiManager.instance.ShowGameOverPanel(false);
    
    UiManager.instance.playerOneWins(false);
    UiManager.instance.playerTwoWins(false);
    
    CreateNewBall();
    // //CreateNewBallTest();
     //currentBallAmount2 = startBallAmount2;
     CreateNewBall2();
  }





  public void CreateNewBall()
  {
    if( currentBallAmount>0 )
    {
    
    Instantiate(ballPrefab,spawnPoint.position,Quaternion.identity);
    currentBallAmount--;
    UiManager.instance.UpdateBallText(currentBallAmount);
    //Debug.Log("PLAYER ONE SCORE" + ScoreManager1.playerOneScore);
    //Debug.Log(currentBallAmount);
    }
    else if( currentBallAmount==0 && currentBallAmount2==0 )
    {
        Debug.Log("GAME OVER PLAYER ONE");
        UiManager.instance.ShowGameOverPanel(true);
       if(ScoreManager1.playerOneScore> ScoreManager1.playerTwoScore)
       {
        UiManager.instance.playerOneWins(true);
        UiManager.instance.ShowGameOverPanel(true);
        }

      else if(ScoreManager1.playerTwoScore> ScoreManager1.playerOneScore)
       {
        UiManager.instance.playerTwoWins(true);
        UiManager.instance.ShowGameOverPanel(true);
        }
    
    
    
    }
  //  if(ScoreManager1.playerOneScore> ScoreManager1.playerTwoScore)
  //       {
  //       UiManager.instance.playerOneWins(true);
  //       UiManager.instance.ShowGameOverPanel(true);
  //       }
  
  }

  public void CreateNewBall2()
  {
    if(currentBallAmount2>0)
    {
    Instantiate(ballPrefab2,spawnPoint2.position,Quaternion.identity);
    currentBallAmount2--;
    UiManager.instance.UpdateBallText2(currentBallAmount2);
    }
      else if(currentBallAmount2==0 && currentBallAmount==0 )
    {
        Debug.Log("GAME OVER PLAYER TWO");
        UiManager.instance.ShowGameOverPanel(true);
     if(ScoreManager1.playerOneScore> ScoreManager1.playerTwoScore)
       {
        UiManager.instance.playerOneWins(true);
        UiManager.instance.ShowGameOverPanel(true);
        }

      else if(ScoreManager1.playerTwoScore> ScoreManager1.playerOneScore)
       {
        UiManager.instance.playerTwoWins(true);
        UiManager.instance.ShowGameOverPanel(true);
        }
      
      // if(ScoreManager1.playerTwoScore> ScoreManager1.playerOneScore)
      //  {
      //   UiManager.instance.playerTwoWins(true);
      //   UiManager.instance.ShowGameOverPanel(true);
      //   }
    
    
    }
  
  }

//  public void CreateNewBallTest()
//   {
    
    
//     Instantiate(ballTest,spawnPoint.position,Quaternion.identity);
//     currentBallAmount--;
    
//   }
  
}
