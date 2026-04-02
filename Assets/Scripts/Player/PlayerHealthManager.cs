using System;
using TMPro;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    // Referência ao TMPro da vida do jogador
    [SerializeField] private TextMeshProUGUI _healthText; 
    
    // Variável que guarda qual a vida máxima que o jogador pode ter
    [SerializeField] private int _maxHealth;
   
    // Variável que guarda qual a vida atual do jogador
    private int _currentHealth;
    
    // Quando o jogos inicía e o script é carregado
    private void Start()
    {
        // A vida atual do jogador fica igual a vida máxima que o mesmo pode ter
        _currentHealth = _maxHealth;
        // Determina que o texto referenciado deve ser "Health: " mais a vida atual do jogador
        _healthText.text = "Health: " + _currentHealth;
    }
    
    private void OnEnable()
    {
        DetectCollision.OnDamageTaken += HandleDamageTaken;
    }
    
    private void OnDisable()
    {
        DetectCollision.OnDamageTaken -= HandleDamageTaken;
    }

    // O que acontece quando a colisão é detectada
    private void HandleDamageTaken(int damage) 
    {
        // A vida atual do jogador diminui na quantidade de dano tomado
        _currentHealth -= damage;
        // Função que cria um limitador máximo e mónimo para a variável, _currentHealth não pode passar de 0 nem de _maxHealth, se passar, torna-se um dos valores determinados
        _currentHealth = Math.Clamp(_currentHealth, 0, _maxHealth);

        // Determina que o texto referenciado deve ser "Health: " mais a vida atual do jogador
        _healthText.text = "Health: " + _currentHealth;

        // Se a vida atual do jogador for zero
        if (_currentHealth <= 0)
        {
            // O método OnDeath é chamado
            OnDeath();
        }
    }

    // O que acontece quando o método é chamado
    private void OnDeath()
    {
        Debug.Log("Game Over");
    }
    
}
