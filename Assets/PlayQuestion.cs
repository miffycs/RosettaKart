using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayQuestion : MonoBehaviour
{
    float blockOffsetX;
    float initAudioPlayZ;
    float[] blockCoordinates;

    // Start is called before the first frame update
    void Start()
    {
        blockOffsetX = (float)2.8;
        initAudioPlayZ = 3;

        //42.8 + 50.8n
        blockCoordinates = new float[6];
        blockCoordinates[0] = (float)42.8;
        for (int i = 1; i < blockCoordinates.Length; i++)
        {
            blockCoordinates[i] += (float)50.8; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = gameObject.transform.position;

        if (playerPosition.z > initAudioPlayZ && playerPosition.z < (blockCoordinates[0] + blockOffsetX))
        {
            Debug.Log("PlayerPositionZ: " + playerPosition.z);
            FindObjectOfType<AudioManager>().Play("chowmein");
        }

        if (playerPosition.z > (blockCoordinates[0] + blockOffsetX) && playerPosition.z < (blockCoordinates[1] + blockOffsetX))
        {
            Debug.Log("PlayerPositionZ: " + playerPosition.z);
            FindObjectOfType<AudioManager>().Play("dimsum");
        }

        if (playerPosition.z > (blockCoordinates[1] + blockOffsetX) && playerPosition.z < (blockCoordinates[2] + blockOffsetX))
        {
            Debug.Log("PlayerPositionZ: " + playerPosition.z);
            FindObjectOfType<AudioManager>().Play("dumpling");
        }

        if (playerPosition.z > (blockCoordinates[2] + blockOffsetX) && playerPosition.z < (blockCoordinates[3] + blockOffsetX))
        {
            Debug.Log("PlayerPositionZ: " + playerPosition.z);
            FindObjectOfType<AudioManager>().Play("friedrice");
        }

        if (playerPosition.z > (blockCoordinates[3] + blockOffsetX) && playerPosition.z < (blockCoordinates[4] + blockOffsetX))
        {
            Debug.Log("PlayerPositionZ: " + playerPosition.z);
            FindObjectOfType<AudioManager>().Play("roastedduck");
        }

        if (playerPosition.z > (blockCoordinates[4] + blockOffsetX) && playerPosition.z < (blockCoordinates[5] + blockOffsetX))
        {
            Debug.Log("PlayerPositionZ: " + playerPosition.z);
            FindObjectOfType<AudioManager>().Play("zhongzi");
        }

    }

}
