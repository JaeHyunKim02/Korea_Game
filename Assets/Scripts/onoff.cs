using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoff : MonoBehaviour
{
    public GameObject m_panel;

    bool state = false;
    // Start is called before the first frame update
    private void Start()
    {
        //gameObject.SetActive(false);
        m_panel.SetActive(false);
    }
    public void On()
    {
        if (state)
        {
            m_panel.SetActive(false);
            print("사라져");
            state = false;
            
        }
        else
        {
            m_panel.SetActive(true);
            print("생겨나");
            state = true;
        }
    }
}