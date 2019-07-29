using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectControl : MonoBehaviour
{
    [SerializeField] float _speed = 3;
    [SerializeField] float _endPosX = -5;
    [SerializeField] float _startPosX = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= _endPosX)
        {
            transform.Translate(Vector3.left * (_endPosX - _startPosX));
            SendMessage("RandomHeight", SendMessageOptions.DontRequireReceiver);//https://itmining.tistory.com/50

        }
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
    }
}
