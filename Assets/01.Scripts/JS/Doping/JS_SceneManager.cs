using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JS_SceneManager : MonoBehaviour
{
    public void ToNextScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
