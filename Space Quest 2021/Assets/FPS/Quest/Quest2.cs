using UnityEngine;
using System.Collections;

public class Quest2 : MonoBehaviour
{
    public static Quest2 instance;
    [SerializeField]
    bool showObjective = false;
    [SerializeField]
    Texture objective;
    [SerializeField]
    private int collision;
    public bool ObjectiveDone;
    public bool MissionSucceeded = false;

    void Start()
    {
        showObjective = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && showObjective == false && collision == 0)
            showObjective = true;
        /*if (GameObject.FindGameObjectWithTag("questcheck").GetComponent<Goal>().CallRecieved)
        {
            FadeManager.instance.FadeOutToScene(3);
        }*/
    }
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
        if (Input.GetButton("ShowObj") && collision == 1 && !ObjectiveDone)
        {
            showObjective = true;
        }
        if (Input.GetButtonUp("ShowObj") && collision == 1)
        {
            showObjective = false;
        }
    }
}