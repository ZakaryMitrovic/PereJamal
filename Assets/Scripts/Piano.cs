using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    [SerializeField] Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickDo(){
        _anim.SetTrigger("Do");
    }
        public void ClickRe(){
        _anim.SetTrigger("Re");
    }
        public void ClickMi(){
        _anim.SetTrigger("Mi");
    }
        public void ClickFa(){
        _anim.SetTrigger("Fa");
    }
        public void ClickSol(){
        _anim.SetTrigger("Sol");
    }
        public void ClickLa(){
        _anim.SetTrigger("La");
    }
        public void ClickSi(){
        _anim.SetTrigger("Si");
    }

}
