using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Cria variável que armazena a velocidade em que o objeto se move
    [SerializeField] private float _speed = 10f;

    private void Update()
    {
        // A cada upate, o objeto se move para frente com velocidade pré-determinada
        transform.Translate(Vector3.forward * (_speed * Time.deltaTime));        
    }
}
