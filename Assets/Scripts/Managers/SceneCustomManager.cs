using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCustomManager : MonoBehaviour
{
    public static event Action<int> LoadScene;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            LoadSceneByIndex(0);
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    public void LoadSceneByIndex(int index)
    {
        LoadScene?.Invoke(index);
        SceneManager.LoadScene(index);
    }
}
