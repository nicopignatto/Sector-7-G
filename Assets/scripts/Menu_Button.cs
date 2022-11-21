using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Menu_Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator anim;

    private void Awake(){
        anim= GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData evento){
        anim.SetBool("handler", true);
    }
    public void OnPointerExit(PointerEventData evento){
        anim.SetBool("handler", false);
    }
}
