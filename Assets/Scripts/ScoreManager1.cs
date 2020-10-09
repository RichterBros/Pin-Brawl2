using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager1 : MonoBehaviour
{
  
  public static ScoreManager1 instance;
  
   public static int playerOneScore = 0;
   public static int playerTwoScore = 0;

  

  void Start()
  {
    UiManager.instance.UpdateScoreText(playerOneScore);
    UiManager.instance.UpdateScoreText2(playerTwoScore);
 
  }
  void Update()
  {
    instance = this;
    UiManager.instance.UpdateScoreText(playerOneScore);
    UiManager.instance.UpdateScoreText2(playerTwoScore);
    
  }
  
  
  public void AddScore(int amount)
  {
      playerOneScore += amount;
      UiManager.instance.UpdateScoreText(playerOneScore);
  
      // playerTwoScore += amount;
      // UiManager.instance.UpdateScoreText(playerTwoScore);
  
  }

  public void AddScore2(int amount)
  {
      // playerOneScore += amount;
      // UiManager.instance.UpdateScoreText(playerOneScore);
  
       playerTwoScore += amount;
       UiManager.instance.UpdateScoreText2(playerTwoScore);
  
  }
 
  public void ResetScore()
  {
    playerOneScore = 0;
    playerTwoScore = 0;

    UiManager.instance.UpdateScoreText(playerOneScore);
    UiManager.instance.UpdateScoreText2(playerTwoScore);

  }
//  void OnGUI()
//   {
//     GUILayout.Label("Player One Score:" + playerOneScore.ToString());
    
//     GUILayout.Label("Player One Balls:" + GameManager.currentBallAmount.ToString());
    
//     GUILayout.Label("Player Two Score:" + playerTwoScore.ToString());

//     GUILayout.Label("Player Two Balls:" + GameManager.currentBallAmount2.ToString());

//     GUILayout.Label("Current Player:" +  GameManager.playerScoring.ToString());

//     GUILayout.Label("ballKillTriggerTest:" + GameManager.ballKillTrigger1.ToString());
//   }

}
