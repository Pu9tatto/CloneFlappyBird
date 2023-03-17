using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    [SerializeField] private float _maxHeight = 6f;

    private BirdMover _mover;
    private int _score;
    private bool _isStartGame = false;

    public bool IsStartGame=> _isStartGame;
    public UnityAction GameOVer;
    public UnityAction<int> ChangedScore;

    private void Start()
    {
        _mover = GetComponent<BirdMover>();
    }

    private void Update()
    {
        if (transform.position.y > _maxHeight)
            Die();
    }

    public void ResetPlayer()
    {
        _score = 0;
        _isStartGame = true;
        ChangedScore?.Invoke(_score);
        _mover.ResetBird();
    }

    public void Die()
    {
        _isStartGame = false;
        GameOVer?.Invoke();
    }
    public void IncreaseScore()
    {
        _score++;
        ChangedScore?.Invoke(_score);
    }
}


