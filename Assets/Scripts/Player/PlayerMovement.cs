using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Parameters")]
    [SerializeField] private float _speed; //Velocidade em que o jogador se desloca

    [Header("Player Bounder")]
    [SerializeField] private float _xRange; //Limite máximo que o jogador pode chegar antes de sair da game view

    [SerializeField] private float _zRangeBottom; //Limite máximo que o jogador pode chegar antes de sair da game view
    [SerializeField] private float _zRangeTop; //Limite máximo que o jogador pode chegar antes de sair da game view

    private void Update()
    {
        MovePlayer();
        ClampPosition();
    }

    void MovePlayer()
    {
        // A variável reserva os valores direcionais do input "Horizontal"
        float _horizontalInput = Input.GetAxis("Horizontal");
        // A variável reserva os valores direcionais do input "Vertical"
        float _verticalInput = Input.GetAxis("Vertical");

        // Cria variável de Vector3 para unificar os translates em um só movimento
        Vector3 _direction = new Vector3(_horizontalInput, 0, _verticalInput);
        transform.Translate(_direction *(_speed * Time.deltaTime));
    }

    void ClampPosition()
    {
        // Cria variável que unifica os valores máximos e mínimos que o transform.position.x pode ter
        float _clampedX = Mathf.Clamp(transform.position.x, -_xRange, _xRange);
        // Cria variável que unifica os valores máximos e mínimos que o transform.position.z pode ter
        float _clampedZ = Mathf.Clamp(transform.position.z, _zRangeBottom, _zRangeTop);

        // Determina que o transform.position do objeto tem os valores que encaixam dentro das normas criadas
        transform.position = new Vector3(_clampedX, transform.position.y, _clampedZ);
    }
        
}
