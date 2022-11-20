using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject panelCreditos;
    // Start is called before the first frame update
    void Start()
    {
        offPanelCreditos();
    }

    // Update is called once per frame
    //void Update(){}

    public void onPanelCreditos(){
        panelCreditos.SetActive(true);
    }
    public void offPanelCreditos(){
        panelCreditos.SetActive(false);
    }
}
