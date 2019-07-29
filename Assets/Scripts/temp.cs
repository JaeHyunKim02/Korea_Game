using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour
{
    bool state = false;
    // Start is called before the first frame update
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void On()
    {
        if (state)
        {
            gameObject.SetActive(false);
            print("사라져");
            state = false;
        }
        else
        {
            gameObject.SetActive(true);
            print("생겨나");
            state = true;
        }
    }
}
