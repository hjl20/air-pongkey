
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int playerScore;
    private int computerScore;

    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public TMP_Text playerScoreText;
    public TMP_Text computerScoreText;

    private void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
    }

    public void PlayerScores()
    {
        playerScore++;

        this.playerScoreText.text = playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        computerScore++;

        this.computerScoreText.text = computerScore.ToString();
        ResetRound();
    }
    
}
