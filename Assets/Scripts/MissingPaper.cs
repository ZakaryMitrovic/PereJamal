using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingPaper : MonoBehaviour
{
    [SerializeField] private Transform parent;

    public void SortDeLaMain()
    {
        Debug.Log("d");
        transform.SetParent(parent);
    }
}
