using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    public string nextSceneName;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nextSceneName);
    }

}
