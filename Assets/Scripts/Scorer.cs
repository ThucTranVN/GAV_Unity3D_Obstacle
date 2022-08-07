using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public PlayerLives playerLives;
    private int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            hits++;
            playerLives.LooseLive();
            Debug.Log("Hit time: " + hits);
            if(hits >= GameManager.Instance.playerLives)
            {
                GameManager.Instance.EndGame();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            if (GameManager.HasInstance)
            {
                GameManager.Instance.WinGame();
            }
            Debug.Log("You've finished the game!!!!");
        }
    }
}
