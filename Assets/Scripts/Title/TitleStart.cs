using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class TitleStart : MonoBehaviour
{
    public GameObject TitleBar;

    // Start is called before the first frame update
    void Start()
    {
        if(TitleBar != null)
        {
            Animator animator = TitleBar.GetComponent<Animator>();
            if(animator != null)
            {
                bool m_IsStart = animator.GetBool("IsStart");
                animator.SetBool("m_IsStart", true);
            }
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
