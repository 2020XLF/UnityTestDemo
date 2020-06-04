using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;
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
        Application.LoadLevel("01-Scene");
    }
}
