using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Parameters")]
    [SerializeField] private float _speed; //Velocidade em que o jogador se desloca

    [Header("Player Bounder")]
    [SerializeField] private float _xRange; //Limite máximo que o jogador pode chegar antes de sair da game view
    
    private float _horizontalInput;

    private void Update()
    {
        // Caso a posição x do jogador seja menor que o limite permitido
        if (transform.position.x < -_xRange)
        {
            // Sua nova posição é setada (limitador) 
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }
        
        // Caso a posição x do jogador seja maior que o limite permitido
        if (transform.position.x > _xRange)
        {
            // Sua nova posição é setada (limitador) 
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }
        
        // A variável reserva os valores direcionais do input "Horizontal"
        _horizontalInput = Input.GetAxis("Horizontal");
        // Mexe o jogador para os lados a partir da velocidade e do input direcional
        transform.Translate(Vector3.right * (Time.deltaTime * _speed * _horizontalInput));
    }
}
