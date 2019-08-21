using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenas : MonoBehaviour
{
    public void LoadInt(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
