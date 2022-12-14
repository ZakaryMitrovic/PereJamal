using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mort : MonoBehaviour
{
    void Start()
    {
    }
    // Start is called before the first frame update
    public void Replay()
    {
        SceneManager.LoadScene("Jeu");
    }

    // Update is called once per frame
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
