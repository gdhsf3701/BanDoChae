using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUi : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        gameObject.SetActive(false);
    }


    public void Restart()
    {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      SceneManager.LoadScene(0);
        Time.timeScale = 1f;

    }
    public void Quit()
    {
        Application.Quit();
    }
}
