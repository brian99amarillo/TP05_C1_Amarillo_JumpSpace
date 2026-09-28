using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private float score;
    [SerializeField] private float multoplicationStore = 100f;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Update()
    {
        score += Time.deltaTime* multoplicationStore;
        scoreText.text = "Score: " + Mathf.Round(score).ToString();
    }
}
