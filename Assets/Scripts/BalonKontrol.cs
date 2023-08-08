using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrol OyunKontrolScripti;
    private void Start()
    {
        OyunKontrolScripti = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
        
    }
    private void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 1.8f);
        OyunKontrolScripti.BalonEkleme();
        
             
    } 

}
