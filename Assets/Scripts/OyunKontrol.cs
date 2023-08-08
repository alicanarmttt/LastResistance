using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zamanText, scoreText, scoreFinal;
    public float zamansayaci = 30f;
    int patlayanBalon = 0;
    public GameObject patlama;
    void Start()
    {
        scoreText.text = "Score: " + patlayanBalon;
    }

    // Update is called once per frame
    void Update()
    {

        if (zamansayaci > 0)
        {
            zamansayaci -= Time.deltaTime;
            zamanText.text = "Time: " + (int)zamansayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }

            SceneManager.LoadScene("bitis");
        }
    }
    public void BalonEkleme()
    {

        patlayanBalon += 1;
        scoreText.text = "Score:" + patlayanBalon;
        PlayerPrefs.SetInt("scoreFinal",patlayanBalon);

    }

}
