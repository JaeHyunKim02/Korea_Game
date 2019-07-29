using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;

    public float Speed = 5;
    public float Jump = 3;

    private bool m_isJumping;
    private bool m_isSlideing;


    // Start is called before the first frame update

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_isJumping)
        {
            if (Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.UpArrow)
            {

            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {

            }
        }
    }
}
