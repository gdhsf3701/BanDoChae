using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text currentScoreUI;
    public int currentScore;
    public Text bestScoreUI;
    public int bestScore= 0;

    public static ScoreManager Instance = null;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreUI.text = "�ְ����� :" + bestScore;
    }
    public void SetScore(int value)
    {
        currentScore = value;
        currentScoreUI.text = "��������: " + currentScore;

        if(currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreUI.text = "�ְ�����: " + bestScore;
            PlayerPrefs.SetInt("BestScore",bestScore);
        }
    }
    public int GetScore()// ���������� �������ִ� �޼��Ѥ�
    {
        return currentScore;
    }
   

}
