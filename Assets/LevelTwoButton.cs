using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTwoButton : MonoBehaviour
{

    public void Button()
    {
        Invoke("LevelTwo", 0.3f);
    }
    private void LevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }
}