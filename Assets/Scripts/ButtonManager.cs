using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void GotoStart()
    {
        SceneManager.LoadScene("MainGame");
        
    }
    public void Gotodogam()
    {
        SceneManager.LoadScene("dogam");

    }
}
