using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetAnimation : MonoBehaviour
{
    void Start()
    {
        Invoke("ResetAnimation", 21.0f);
    }

    void ResetAnimation()
    {
        SceneManager.LoadScene("Project 2");
    }
}

