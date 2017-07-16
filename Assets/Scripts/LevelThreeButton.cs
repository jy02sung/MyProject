using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelThreeButton : MonoBehaviour
{

    public void Button()
    {
        Invoke("LevelThree", 0.3f);
    }
    private void LevelThree()
    {
        SceneManager.LoadScene("LevelThree");
    }
}