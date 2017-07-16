using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneButton : MonoBehaviour
{

    public void Button()
    {
        Invoke("LevelOne", 0.3f);
    }
    private void LevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }
}