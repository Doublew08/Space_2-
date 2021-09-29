using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool CallRecieved = false;
    private bool istriggered = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (istriggered == false)
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.Find("Quest1").GetComponent<Quest>().ObjectiveDone = true;

                istriggered = true;
                CallRecieved = true;
            }

        }

    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
           // istriggered = false;
        }
    }
}