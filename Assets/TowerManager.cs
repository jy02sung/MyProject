using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class TowerInfo
{
    public GameObject Tower;
    public int Price;
}

public class TowerManager : MonoBehaviour
{
    public List<TowerInfo> Info;
    public int Index = -1;
    public static TowerManager Instance;
	// Use this for initialization
	void Start () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
