using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void BackMain()
    {
        SceneManager.LoadScene(0);
        print("mvflmfl;mfdldfknbngfbkg");
    }
}
