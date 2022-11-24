using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private HingeJoint hJ;
    [SerializeField] private PortesSousSol pSG;
    [SerializeField] private PortesSousSol pSD;
    // Start is called before the first frame update
    void Start()
    {
        hJ=GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        ActiverLevier();
        Debug.Log(hJ.angle);
    }

    private void ActiverLevier(){
        if(hJ.angle >= 170){
            Debug.Log("it works");
            pSG.DebarrerPorteSousSol();
            pSD.DebarrerPorteSousSol();
        }
    }
}
