using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  
  public static GameManager instance;
  public static int playerOne = 0;
  public static int startBallAmount = 3;

  public static int startBallAmount2 = 3;
  public static int currentBallAmount;

  public static int currentBallAmount2;

  //SPAWNBALL
  public GameObject ballPrefab;
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
    
  }
	
  void ResetGame()
  {
    currentBallAmount = startBallAmount;
    CreateNewBall();
    currentBallAmount2 = startBallAmount2;
    CreateNewBall2();
  }





  public void CreateNewBall()
  {
    Instantiate(ballPrefab,spawnPoint.position,Quaternion.identity);
    currentBallAmount--;
  }

  public void CreateNewBall2()
  {
    Instantiate(ballPrefab,spawnPoint2.position,Quaternion.identity);
    currentBallAmount2--;
  }

  
}
