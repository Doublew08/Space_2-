using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCollectFuel : MonoBehaviour
{
    bool showObjective = false;
    private int collision;
    Texture objective;
    public bool ObjectiveDone;
    public GameObject[] Boxes;
   public int RndBox ;
    private void Awake()
    {
        RndBox = Random.Range(0, 8);
    }
    void Start()
    {
        
    }
    

    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && showObjective == false && collision == 0)
            showObjective = true;
        
    }*/
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            showObjective = false;
        collision = 1;
    }
    void OnGUI()
    {
        if (showObjective == true)
            GUI.DrawTexture(new Rect(Screen.width / 1.5f, Screen.height / 1.4f, 300, 300), objective);
    }
    void Update()
    {
        if (!ObjectiveDone)
        {
            foreach (GameObject gameObject in Boxes)
            {
                if (gameObject.GetComponent<Box>().BoxNum == RndBox)
                {
                    ObjectiveDone = true;
                }
                else
                {
                    print("Search again");
                }
            }
        }
        if (Input.GetButton("ShowObj") && collision == 1 && !ObjectiveDone)
        {
            showObjective = true;
        }
        if (Input.GetButtonUp("ShowObj") && collision == 1)
        {
            showObjective = false;
        }
    }
   public void ButtonHeld()
    {
        Debug.Log("done");
    }
}
