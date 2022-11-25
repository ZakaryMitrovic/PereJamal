using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerScene : MonoBehaviour
{
    private string _destination;

    public void Aller(string nouvelleScene){
        _destination = nouvelleScene;
        Invoke("Go",0.3f);
    }

    private void Go(){
        SceneManager.LoadScene(_destination);
    }
}
