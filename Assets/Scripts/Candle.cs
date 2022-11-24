using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    [SerializeField] private GameObject _fire;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fire"))
        {
            _fire.SetActive(true);
        }
    }
}
