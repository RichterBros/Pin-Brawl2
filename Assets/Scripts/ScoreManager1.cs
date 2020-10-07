using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager1 : MonoBehaviour
{
   public static int playerOneScore = 0;
   public static int playerTwoScore = 0;

  void OnGUI()
  {
    GUILayout.Label("Player One Score:" + playerOneScore.ToString());
    
    GUILayout.Label("Player One Balls:" + GameManager.currentBallAmount.ToString());
    
    GUILayout.Label("Player Two Score:" + playerTwoScore.ToString());

    GUILayout.Label("Player Two Balls:" + GameManager.currentBallAmount2.ToString());

    GUILayout.Label("Current Player:" +  GameManager.playerScoring.ToString());

    GUILayout.Label("ballKillTriggerTest:" + GameManager.ballKillTrigger1.ToString());
  }

}
