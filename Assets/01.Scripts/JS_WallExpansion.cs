using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JS_WallExpansion : MonoBehaviour
{
    [SerializeField]
    BoxCollider2D boxCollider;
    [SerializeField]
    private float sizeLimit;

    private Coroutine coroutine;
    private void OnEnable()
    {
        coroutine = StartCoroutine(WallExpansion());
    }

    private void OnDisable()
    {
        boxCollider.size = new Vector2(0.5f, 5.5f);
        StopCoroutine(coroutine);
    }
    
    IEnumerator WallExpansion()
    {
        yield return new WaitForSeconds(3);
        while (boxCollider.size.x < sizeLimit)
        {
            yield return null;
            boxCollider.size += new Vector2(0.01f, 0);
        }
    }
}
