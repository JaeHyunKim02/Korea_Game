using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigidbody;
   

    public float Speed = 5;
    public float JumpPower = 100;

    private bool m_isJumping;
    private bool m_isSlideing;
    private bool m_isRuning;
    private bool m_isDie;


    // Start is called before the first frame update

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            //Log("바닥 감지!");
            m_isJumping = false;
            m_isRuning = true;

            
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Slang")
        {
            Debug.Log("안좋은거");
            Destroy(other);
        }
        else if(other.gameObject.tag == "Standard")
        {
            Debug.Log("좋은거");
            Destroy(other);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_isJumping)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                m_isJumping = true;
                rigidbody.velocity = new Vector3(0, 7, 0);
                animator.SetBool("IsJump", true);
                animator.SetBool("IsRun", false);
                //Debug.Log("점핑");
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("슬라이딩 시작");
                m_isSlideing = true;
                animator.SetBool("IsSlide", true);
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                Debug.Log("슬라이딩 끝");
                m_isSlideing = false;
                animator.SetBool("IsSlide", false);
                animator.SetBool("IsRun", true);
            }
        }
        //if (m_isRuning)
        //    animator.SetBool("IsRun", true); -*+

        if (!m_isJumping)
        {
            animator.SetBool("IsJump", false);
            animator.SetBool("IsRun", true);
        }
    }

}
