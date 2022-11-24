using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    [SerializeField] private GameObject _fire;

    public void Allumer()
    {
        _fire.SetActive(true);
    }

    public void Eteindre()
    {
        _fire.SetActive(false);
    }
}
