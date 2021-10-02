using UnityEngine;
using System.Collections;
using Unity;

public class QuestPlanet : MonoBehaviour
{
    public static Quest instance;
    [SerializeField]
    bool showObjective = false;
    [SerializeField]
    Texture objective;
    [SerializeField]
    private int collision;
    float time;
    public GameObject Credits;
   // public bool ObjectiveDone;
   // public bool MissionSucceeded = false;
    public GameObject Capsule;

    void Start()
    {
        showObjective = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && showObjective == false && collision == 0)
            showObjective = true;
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                showObjective = false;
                StartCoroutine(Time());
            }
        }
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
        if (Input.GetButton("ShowObj") && collision == 1 )
        {
            showObjective = true;
        }
        if (Input.GetButtonUp("ShowObj") && collision == 1)
        {
            showObjective = false;
        }
       

    }
    IEnumerator Time()
    {
        Capsule.SetActive(true);
        yield return new WaitForSeconds(3f);
        Credits.SetActive(true);
        yield return new WaitForSeconds(60f);
        Application.Quit();



    }
}