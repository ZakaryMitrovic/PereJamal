using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    [SerializeField] private GameObject _fire;
    [SerializeField] private Material _waxAllumer;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fire"))
        {
            _fire.SetActive(true);
            Material[] mats = GetComponent<MeshRenderer>().materials;
            mats[0] = _waxAllumer;
            GetComponent<MeshRenderer>().materials = mats;
        }
    }
}
