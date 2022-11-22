using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject panelCreditos;
    [SerializeField] private GameObject UIHuman;

    // Start is called before the first frame update
    void Start()
    {
        offPanelCreditos();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouspos= Input.mousePosition;
        if(mouspos.x >= 854f) UIHuman.transform.localScale= new Vector3(-1.8f, 1.8f, 1f);
        if(mouspos.x <= 750f) UIHuman.transform.localScale= new Vector3(1.8f, 1.8f, 1f);
    }

    public void onPanelCreditos(){
        panelCreditos.SetActive(true);
    }
    public void offPanelCreditos(){
        panelCreditos.SetActive(false);
    }
}
