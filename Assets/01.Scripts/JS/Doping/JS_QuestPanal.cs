using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JS_QuestPanal : MonoBehaviour
{
    [SerializeField]
    Sprite completeSprite;
    [SerializeField]
    GameObject nextSceneButton;

    private int completeCount;
    public void SetComplete(int index)
    {
        transform.GetChild(index).GetChild(1).GetComponent<Image>().sprite = completeSprite;
        CompleteCheck();
    }
    private void CompleteCheck()
    {
        completeCount++;
        if (completeCount >= transform.childCount-1) 
        {
            nextSceneButton.SetActive(true);
        }
    }
}
