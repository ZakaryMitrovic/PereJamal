using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    [SerializeField] Animator _anim;
    [SerializeField] GameObject _briquet;

    // Start is called before the first frame update
    void Start()
    {
        _anim.GetComponent<Animator>();
        _briquet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickDo(){
        _anim.SetTrigger("Do");
        _briquet.SetActive(true);
    }
        public void ClickRe(){
        _anim.SetTrigger("Re");
        _briquet.SetActive(true);
    }
        public void ClickMi(){
        _anim.SetTrigger("Mi");
        _briquet.SetActive(true);
    }
        public void ClickFa(){
        _anim.SetTrigger("Fa");
        _briquet.SetActive(true);
    }
        public void ClickSol(){
        _anim.SetTrigger("Sol");
        _briquet.SetActive(true);
    }
        public void ClickLa(){
        _anim.SetTrigger("La");
        _briquet.SetActive(true);
    }
        public void ClickSi(){
        _anim.SetTrigger("Si");
        _briquet.SetActive(true);
    }

}
