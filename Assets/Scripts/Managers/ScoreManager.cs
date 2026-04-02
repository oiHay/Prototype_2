using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText; //Referencia a UI de texto

    private int _scoreCounter; //variável que armazena o valor do score do player

    private void Start()
    {
        _scoreText.text = "Score: " + 0;
    }

    private void OnEnable()
    {
        AnimalHunger.OnAnimalSatisfied += HandleAnimalFed;
    }
    
    private void OnDisable()
    {
        AnimalHunger.OnAnimalSatisfied -= HandleAnimalFed;
    }

    private void HandleAnimalFed(int foodNeeded)
    {
        _scoreCounter += foodNeeded;
        _scoreText.text = "Score: " + _scoreCounter;
    }
}
