using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadnextscene : MonoBehaviour
{
    private int loadnextscene21;
    void Start()
    {
        loadnextscene21 = SceneManager.GetActiveScene().buildIndex +1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
