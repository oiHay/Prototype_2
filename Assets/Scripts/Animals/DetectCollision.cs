using System;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    [SerializeField] private bool _isEnemy = false;
    
    // Método para detectar colisão de um objeto com um trigger
    private void OnTriggerEnter(Collider other)
    {
        if (_isEnemy && other.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            return;
        }
        
        // Se ocorrer a colisão entre o objeto que possui o script e outro objeto com a tag "Projectile"
        if (other.CompareTag("Projectile"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            // Ambos objetos se destroem
        }
    }
}
