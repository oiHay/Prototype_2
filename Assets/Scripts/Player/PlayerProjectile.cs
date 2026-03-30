using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    // Cria referência do prefab usado como projectile
    [SerializeField] private GameObject _projectile;
    // Cria variável de input, botão que será apertado
    [SerializeField] private KeyCode _shootInput;

    private void Update()
    {
        // Quando o botão direcionado pela variável _shootInput é apertado
        if (Input.GetKeyDown(_shootInput))
        {
            // Uma nova instância do prefab de projectile é criado na posição atual do objto que carrega o script
            Instantiate(_projectile, transform.position, transform.rotation);
        }
    }
}
