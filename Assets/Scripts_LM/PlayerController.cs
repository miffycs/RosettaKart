using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{


	public Text countText;
	public Text winText;

	private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText ();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Right Answer"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }

        if (other.gameObject.CompareTag ("Wrong Answer"))
        {
            other.gameObject.SetActive (false);
        }
    }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= 6)
        {
            winText.text = "You've LEARN A NEW LANGUAGE!";
        }
    }
}
