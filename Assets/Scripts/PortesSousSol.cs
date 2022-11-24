using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortesSousSol : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DebarrerPorteSousSol(){
        rb.freezeRotation = false;
    }
}
