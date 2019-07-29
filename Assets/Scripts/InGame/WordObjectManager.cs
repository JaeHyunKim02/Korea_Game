using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordObjectManager : MonoBehaviour
{
    public float Spawntimer = 5.0f;
    public GameObject Word1;
    public GameObject Word2;

    public GameObject Word3;
    public GameObject Word4;
    private void Start()
    {
        StartCoroutine("WordSpawn");    
    }

    IEnumerator WordSpawn()
    {
        yield return new WaitForSeconds(Spawntimer);

        int rand = Random.Range(1, 3);//(1~9)

        switch (rand) {
            case 1:
            Instantiate(Word1, new Vector3(8, 1.5f, 0), Quaternion.identity);
            Instantiate(Word2, new Vector3(8, -2.3f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(Word3, new Vector3(8, 1.5f, 0), Quaternion.identity);
                Instantiate(Word4, new Vector3(8, -2.3f, 0), Quaternion.identity);
                break;
        }
        StartCoroutine("WordSpawn");

    }
}
