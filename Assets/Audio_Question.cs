using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Question : MonoBehaviour
{
    float blockOffsetX;
    float initAudioPlayZ;
    float[] blockCoordinates;

    // Start is called before the first frame update
    void Start()
    {
        blockOffsetX = (float)0;
        initAudioPlayZ = 3;

        //42.8 + 50.8n
        blockCoordinates = new float[6];
        blockCoordinates[0] = (float)42.8;
        for (int i = 1; i < blockCoordinates.Length; i++)
        {
            blockCoordinates[i] = blockCoordinates[i-1] + (float)50.8;
            Debug.Log(blockCoordinates[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Audio_1"))
        {
            FindObjectOfType<AudioManager>().Play("friedrice");
        }
        if (other.gameObject.CompareTag ("Audio_2"))
        {
            FindObjectOfType<AudioManager>().Play("dumpling");
        }
        if (other.gameObject.CompareTag ("Audio_3"))
        {
            FindObjectOfType<AudioManager>().Play("dimsum");
        }
        if (other.gameObject.CompareTag ("Audio_4"))
        {
            FindObjectOfType<AudioManager>().Play("chowmein");
        }
        if (other.gameObject.CompareTag ("Audio_5"))
        {
            FindObjectOfType<AudioManager>().Play("roastedduck");
        }
        if (other.gameObject.CompareTag ("Audio_6"))
        {
            FindObjectOfType<AudioManager>().Play("zongzi");
        }
    }
}