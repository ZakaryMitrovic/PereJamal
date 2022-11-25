using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortesArc : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private GameObject _key;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _anim.SetBool("OuvrirPortes", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OuvrirPortesArc(){
        _anim.SetBool("OuvrirPortes", true);
        Destroy(_key);
    }
}
