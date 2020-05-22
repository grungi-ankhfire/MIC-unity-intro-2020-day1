using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timeout : MonoBehaviour
{

    public float time;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0f)
            SceneManager.LoadScene(0);
    }
}
