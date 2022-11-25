using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortesSousSol : MonoBehaviour
{
    [SerializeField] private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("ouvrirPortes", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DebarrerPorteSousSol(){
        anim.SetBool("ouvrirPortes", true);
    }
}
