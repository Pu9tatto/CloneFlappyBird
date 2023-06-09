using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _bird.ChangedScore += OnChangeScore;
    }

    private void OnDisable()
    {
        _bird.ChangedScore -= OnChangeScore;
    }

    private void OnChangeScore(int score)
    {
        _score.text = score.ToString();
    }
}
