using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ChickWay : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        //button.onClick.AddListener(delegate() { Debug.Log("Click"); }) ;
        button.onClick.AddListener(ChangeScence);
    }
    void ChangeScence()
    {
        //string scenceName = "01-Sence";
        Debug.Log("Click");
        //Application.LoadLevel("01-Scene");
        SceneManager.LoadScene("01-Scene");
    }
}
