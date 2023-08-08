using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
    public UnityEngine.UI.Text score;
    
    private void Start()
    {

        int scoreFinal = PlayerPrefs.GetInt("scoreFinal");
        score.text = "Score: " + scoreFinal;


    }
    // Start is called before the first frame update
    public void Diger_sahne()
    {
        SceneManager.LoadScene("oyun");
    }



    // Start is called before the first frame update
    public void Tekrar_basla()
    {
        SceneManager.LoadScene("Ana_sahne");
        
    }
    
}
