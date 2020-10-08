using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    public Text  playerOneScoreText;
    public Text  playerOneBallAmountText;

    public Text  playerTwoScoreText;
    public Text  playerTwoBallAmountText;

    public GameObject gameOverPanel;

    public GameObject playerOneWinsText;

    public GameObject playerTwoWinsText;
   
    void Awake()
    {
        instance = this;
    }

    public void ShowGameOverPanel(bool on)
    {
        gameOverPanel.SetActive(on);
    }

    public void playerOneWins(bool on)
    {
        playerOneWinsText.SetActive(on);
    }

    public void playerTwoWins(bool on)
    {
        playerTwoWinsText.SetActive(on);
    }
    public void UpdateBallText(int amount)
    {
        playerOneBallAmountText.text = "Player One Balls: " + amount;
        //playerTwoBallAmountText.text = "Player Two Balls: " + amount;
    }
    public void UpdateBallText2(int amount2)
    {
        //playerOneBallAmountText.text = "Player One Balls: " + amount;
        playerTwoBallAmountText.text = "Player Two Balls: " + amount2;
    }
    public void UpdateScoreText(int amount)
    {
        playerOneScoreText.text = "Player One Score: " + amount.ToString("D5");
        //playerTwoScoreText.text = "Player Two Score: " + amount.ToString("D5");
    }

    public void UpdateScoreText2(int amount2)
    {
        //playerOneScoreText.text = "Player One Score: " + amount.ToString("D5");
        playerTwoScoreText.text = "Player Two Score: " + amount2.ToString("D5");
    }

}
