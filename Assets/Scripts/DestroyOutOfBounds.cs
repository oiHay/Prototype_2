using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Variável para determinar o limíte que o objeto pode chegar ao sair pela parte de cima da tela
    [SerializeField] private float _topBound = 25f;
    // Variável para determinar o limíte que o objeto pode chegar ao sair pela parte debaixo da tela
    [SerializeField] private float _lowerBound = -10f;

    private void Update()
    {
        // Se um objeto sair da game view, remova o objeto
        if (transform.position.z > _topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < _lowerBound)
        {
            Debug.Log("Gama Over");
            Destroy(gameObject);
        }
    }
}
