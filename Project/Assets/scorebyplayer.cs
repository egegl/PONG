using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorebyplayer : MonoBehaviour
{
    public bool isPlayerLeftScore;
    public bool isPlayerRightScore;
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            audioSource.Play();

            if (isPlayerLeftScore)
            {
                Debug.Log("Left Player Scored!");
                GameObject.Find("GameBrain").GetComponent<GameBrain>().PlayerLeftScore();
            }
            else if (isPlayerRightScore)
            {
                Debug.Log("Right Player Scored!");
                GameObject.Find("GameBrain").GetComponent<GameBrain>().PlayerRightScore();
            }
        }
    }
}
