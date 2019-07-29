using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour
{
    [SerializeField] float _minHeight = -4.65f;
    [SerializeField] float _maxHeight = -3.4f;

    //CoinControl cc;
    GameObject blockAni;
    static BlockControl _uniqueInstance;
    public static BlockControl _instance
    {
        get
        {
            return _uniqueInstance;
        }
    }
    private void Awake()
    {
        _uniqueInstance = this;
    }

    void Start()
    {
        //cc = GetComponentInChildren<CoinControl>();
        //blockAni = GameObject.Find("BlockAnimation");
        //blockAni.SetActive(false);
        RandomHeight();
    }

    void Update()
    {

    }
    void RandomHeight()
    {
        //float height = Random.Range(_minHeight, _maxHeight);
        //transform.position = new Vector3(transform.position.x, height);
        //int rd = Random.Range(0, 2);
        //if (rd == 0)
        //{
        //    cc.EnableCoin(false);
        //}
        //else
        //{
        //    cc.EnableCoin(true);
        //}

        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        //blockAni.SetActive(false);
    }
    //public void onAnimation()
    //{
    //    blockAni.SetActive(true);
    //}
}
