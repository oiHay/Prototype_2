using System;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    [SerializeField] private Slider _hungerSlider;

    [SerializeField] private int _amountToBeFed;

    private int _currentFedAmount = 0;

    public static event Action<int> OnAnimalSatisfied;

    private void Start()
    {
        _hungerSlider.maxValue = _amountToBeFed;
        _hungerSlider.value = 0;
        _hungerSlider.fillRect.gameObject.SetActive(false);
    }


    public void Feed(int giveFood)
    {
        _currentFedAmount += giveFood;
        _hungerSlider.fillRect.gameObject.SetActive(true);
        _hungerSlider.value = _currentFedAmount;

        if (_currentFedAmount >= _amountToBeFed)
        {
            OnAnimalSatisfied?.Invoke(_amountToBeFed);
            Destroy(gameObject);
        }

    }
}
