using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameBrain : MonoBehaviour
{
    [Header("Ball")]
    public GameObject Ball;

    [Header("PlayerLeft")]
    public GameObject PlayerLeftPlayerpaddle;
    public GameObject LeftWall;

    [Header("PlayerRight")]
    public GameObject PlayerRightPlayerpaddle;
    public GameObject RightWall;

    [Header("Score")]
    public GameObject LeftScore;
    public GameObject RightScore;

    private int LeftScoreNumber;
    private int RightScoreNumber;

    public void PlayerLeftScore()
    {
        LeftScoreNumber++;
        LeftScore.GetComponent<TextMeshProUGUI>().text = LeftScoreNumber.ToString();
        NewRound();
    }

    public void PlayerRightScore()
    {
        RightScoreNumber++;
        RightScore.GetComponent<TextMeshProUGUI>().text = RightScoreNumber.ToString();
        NewRound();
    }

    private void NewRound()
    {
        Ball.GetComponent<Ball>().Reset();
        PlayerLeftPlayerpaddle.GetComponent<playerpaddle>().Reset();
        PlayerRightPlayerpaddle.GetComponent<playerpaddle>().Reset();
    }   
}
