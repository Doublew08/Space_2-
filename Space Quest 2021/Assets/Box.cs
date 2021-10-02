using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int BoxNum = -1;
    bool showObjective = false;
    bool showFoundFuel = false;
    bool showNotThis = false;


    [SerializeField]
   Texture objective;
    [SerializeField]
    Texture FoundFuel;
    [SerializeField]
    Texture NotThis;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            showObjective = true;
            
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            print("Convert");
            BoxNum = int.Parse(gameObject.name);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (BoxNum == GameObject.Find("Quest1 (1)").GetComponent<QuestCollectFuel>().RndBox)
            {
                showFoundFuel = true;

            }
            else
            {
                showNotThis = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            showObjective = false;
        showFoundFuel = false;
        showNotThis = false;
    }
    void OnGUI()
    {
        if (showObjective == true)
            GUI.DrawTexture(new Rect(Screen.width / 1.5f, Screen.height / 1.4f, 300, 300), objective);
        if(showFoundFuel == true)
            GUI.DrawTexture(new Rect(Screen.width / 6f, Screen.height / 1.4f, 300, 300), FoundFuel);
        if (showNotThis)
        {
            GUI.DrawTexture(new Rect(Screen.width / 6f, Screen.height / 1.4f, 300, 300), NotThis);
        }

    }
}
