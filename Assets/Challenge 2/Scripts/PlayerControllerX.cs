using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    [SerializeField] private float _dogSpawnInterval;

    private float _dogSpawnDelay;
    private bool _canSpawn = false;

    // Update is called once per frame
    void Update()
    {
        if (!_canSpawn)
        {
            _dogSpawnDelay += Time.deltaTime;

            if (_dogSpawnDelay >= _dogSpawnInterval)
            {
                _canSpawn = true;
            }
        }
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && _canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            _dogSpawnDelay = 0;
            _canSpawn = false;
        }
    }
}
