using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    private BirdMover _mover;
    private int _score;

    public UnityAction<int> ChangedScore;

    private void Start()
    {
        _mover = GetComponent<BirdMover>();
    }

    public void ResetPlayer()
    {
        _score = 0;
        ChangedScore?.Invoke(_score);
        _mover.ResetBird();
    }

    public void Die()
    {
        Debug.Log("DIE");
        Time.timeScale = 0;
    }
    public void IncreaseScore()
    {
        _score++;
        ChangedScore?.Invoke(_score);
    }
}


