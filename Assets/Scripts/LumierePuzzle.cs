using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LumierePuzzle : MonoBehaviour
{
    [SerializeField] private GameObject[] lights;

    public void AllumerLight(int index)
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].SetActive(false);
        }
        lights[index].SetActive(true);
    }
}
