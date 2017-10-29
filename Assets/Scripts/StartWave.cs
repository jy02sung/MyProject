using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class waveInfo
{
    public GameObject Enemy;
    public int count;
    public float delay;
}

[System.Serializable]
public class wave
{
    public List<waveInfo> waveList;
}

public class StartWave : MonoBehaviour
{
    public List<wave> waves;
    public int waveIndex;
    public GameObject text;
    public GameObject button;
    bool start = false;
    List<float> coolTime = new List<float>();
    List<int> spawnNum = new List<int>();


    public void Button()
    {
        Invoke("startgame", 0.3f);
    }

    private void startgame()
    {
        start = true;
        coolTime.Clear();
        spawnNum.Clear();

        for (int i = 0; i < waves[waveIndex].waveList.Count; i++)
        {
            coolTime.Add(0.0f);
            spawnNum.Add(0);
        }
    }

    void Update()
    {
        if (!start)
            return;

        wave nowWave = waves[waveIndex];

        for(int i = 0; i < nowWave.waveList.Count; i++)
        {
            if (spawnNum[i] < nowWave.waveList[i].count)
            {
                coolTime[i] += Time.deltaTime;

                if (coolTime[i] >= nowWave.waveList[i].delay)
                {
                    Instantiate(nowWave.waveList[i].Enemy);
                    spawnNum[i]++;
                    coolTime[i] -= nowWave.waveList[i].delay;
                }
            }
        }

        if(isAllSpawn())
        {
            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                button.SetActive(true);
                start = false;
                waveIndex++;
                text.GetComponent<Text>().text = "Wave " + (waveIndex + 1).ToString();
            }
        }
    }

    bool isAllSpawn()
    {
        wave nowWave = waves[waveIndex];
        for (int i = 0; i < nowWave.waveList.Count; i++)
        {
            if (spawnNum[i] < nowWave.waveList[i].count)
            {
                return false;
            }
        }
        return true;
    }
}