using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nametag : MonoBehaviour
{
    [SerializeField] private GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nameTag(){
        Debug.Log("Works");
        key.SetActive(true);
    }
}
