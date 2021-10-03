using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadComingscene : MonoBehaviour
{
    public int sceneload;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enumerator());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Enumerator()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(sceneload);
    }
}
