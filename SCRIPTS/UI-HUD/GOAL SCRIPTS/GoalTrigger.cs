using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GoalManager GoalDetector;

    void OnTriggerEnter2D(Collider2D other)
    {
        GoalDetector.ScoreBoard();
    }
}

