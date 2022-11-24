using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private LumierePuzzle _light;

    public bool isAtPuzzle3 = false;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && isAtPuzzle3 == true)
        {
            _light.AllumerLight(3);
        }
    }
}
