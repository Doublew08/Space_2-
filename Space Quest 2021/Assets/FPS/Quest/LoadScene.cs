using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        FadeManager.instance.FadeOutToScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
