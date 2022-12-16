using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortesArc : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private GameObject _key;
    public GameObject fadeScreen;
    private float duration;
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
        StartCoroutine("Fin");
    }

    IEnumerator Fin(){
        while(duration < 1f)
        {
            duration += 0.01f;
            fadeScreen.GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f, duration);
            yield return new WaitForSeconds(0.01f);
        }           
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Victoire");
    }
}
