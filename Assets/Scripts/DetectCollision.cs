using System;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Método para detectar colisão de um objeto com um trigger
    private void OnTriggerEnter(Collider other)
    {
        // Se ocorrer a colisão entre o objeto que possui o script e outro objeto com a tag "Projectile"
        if (other.CompareTag("Projectile"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            // Ambos objetos se destroem
        }
    }
}
