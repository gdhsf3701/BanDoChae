using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YameUI : MonoBehaviour
{
   public void Quit()
   {
        Application.Quit();
   }

    public void ReLoad()
    {
        SceneManager.LoadScene("KAY_Game");
        Time.timeScale = 1.0f;
    }
}
