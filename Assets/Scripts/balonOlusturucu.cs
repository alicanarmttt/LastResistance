using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi = 1f;
    float zamansayaci = 0f;
    OyunKontrol okScripti;

    // Start is called before the first frame update
    void Start()
    {
        okScripti = this.gameObject.GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        zamansayaci -= Time.deltaTime;
        if(zamansayaci<0 && okScripti.zamansayaci>0)
        {
            int katsay� = (int)(zamansayaci / 10) - 5;
            katsay� *= -1;
            GameObject go = Instantiate(balon, new Vector3 (Random.Range(-2.30f,3.30f), -6.4f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(30f*katsay�,80f*katsay�),0));
            zamansayaci = balonOlusturmaSuresi;
         
        }
        
    }
}
