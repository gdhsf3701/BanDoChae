using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JS_RollBack : MonoBehaviour
{
    private Vector3[] positivesMemory;
    private Vector3[] negativesMemory;

    [SerializeField]
    private GameObject positiveParent;
    [SerializeField]
    private GameObject negativeParent;

    private GameObject[] positives;
    private GameObject[] negatives;

    void OnEnable()
    {
        int childCount = positiveParent.transform.childCount;

        // Initialize memory arrays based on child count
        positivesMemory = new Vector3[childCount];
        negativesMemory = new Vector3[childCount];

        positives = new GameObject[childCount];
        negatives = new GameObject[childCount];

        for (int j = 0; j < childCount; j++)
        {
            positives[j] = positiveParent.transform.GetChild(j).gameObject;
            negatives[j] = negativeParent.transform.GetChild(j).gameObject;

            // Store initial positions
            positivesMemory[j] = positives[j].transform.position;
            negativesMemory[j] = negatives[j].transform.position;
        }

    }

    void OnDisable()
    {
        if (positivesMemory == null || negativesMemory == null)
        {
            Debug.LogWarning("Memory positions not initialized!");
            return;
        }

        for (int i = 0; i < positives.Length; i++)
        {
            positives[i].transform.position = positivesMemory[i];
            negatives[i].transform.position = negativesMemory[i];
        }
    }
}
