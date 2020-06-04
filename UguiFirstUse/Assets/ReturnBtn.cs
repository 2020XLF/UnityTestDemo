using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ReturnBtn : MonoBehaviour
{
    public Button returnRutton;
    // Start is called before the first frame update
    void Start()
    {
        returnRutton.onClick.AddListener(this.ChangeMainScence);
    }

    void ChangeMainScence()
    {
        //string scenceName = "01-Sence";
        Debug.Log("Click");
        //Application.LoadLevel("MainScene");
        SceneManager.LoadScene("MainScene");
    }
}
