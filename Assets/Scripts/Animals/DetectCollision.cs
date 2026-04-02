using System;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // [SerializeField] private bool _isEnemy = false;

    public static event Action<int> OnDamageTaken;
    // Evento estático poís mais de um inimigo dispara o metodo, isso garante que quando a ação for chamada ela sempre terá "o mesmo valor
    // "event" é um modificador que restringe o acesso, impedindo que classes externas disparem ou zerarem o evento, só podendo se inscrever/desinscrever.
    // "Action" é uma variável que armazena referências a métodos
    // int após Action implica que um valor numérico deve ser passado para o método, é a quantidade de dano que o jogador sofre
    
    // Método para detectar colisão de um objeto com um trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnDamageTaken?.Invoke(1);
            // Destroy(gameObject);
            return;
        }
        
        // Se ocorrer a colisão entre o objeto que possui o script e outro objeto com a tag "Projectile"
        if (other.CompareTag("Projectile"))
        {
            // Pega o AnimalHunger do próprio objeto e chama direto
            if (TryGetComponent<AnimalHunger>(out AnimalHunger hunger))
            {
                hunger.Feed(1);
            }
            Destroy(other.gameObject);
        }
    }
}
