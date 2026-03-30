using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("References")]
    // Cria um array (lista) de referências dos animais
    [SerializeField] private GameObject[] _animalsPrefab;

    [Header("Spawn ")]
    // Variável para determinar o limite máximo e mínimo de spawn dos animais na tela
    [SerializeField] private float _spawnRangeX;
    // Variável para determinar em qual "altura" da tela os animais serão spawnados
    [SerializeField] private float _spawnPosZ;
    //Variável para determinar o tempo inicial de delay, quanto tempo passa até começar a spawnar
    [SerializeField] private float _startDelay = 2f;
    //Variável para determinar o tempo de intervalo entre spawns
    [SerializeField] private float _spawnInterval= 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", _startDelay, _spawnInterval);
    }

    private void SpawnRandomAnimals()
    {
        // Essa função cria variação na posição dos animais quando são spawnados, contendo um range máximo e mínimo no vetor x, 0 no vetor y e valor específico no vetor z
        Vector3 _spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);
            
        // Essa função cria uma variável específica para essa função que guardar um valor random entre 0 e 2 (sendo 2 o limite da lista de _animalsPrefab)
        int _animalIndex = Random.Range(0, _animalsPrefab.Length);
            
        // Após pegar o valor aleatório, um desses animais será criado na cena nos valores gerados pela variável _spawnPos
        Instantiate(_animalsPrefab[_animalIndex], _spawnPos, _animalsPrefab[_animalIndex].transform.rotation);
    }
}
