using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager _instans = new GameManager(); // 독립성 보장
    ResourceManager _Resources = new ResourceManager();


    public static GameManager Instans { get { Init(); return _instans; } }
    public static ResourceManager Resource { get { return _instans._Resources; } }


    static void Init()
    {
        if(_instans == null)
        {
            GameObject go = GameObject.Find("GameManager");
            if(go == null)
            {
                go = new GameObject { name = "GameManager" };
                go.AddComponent<GameManager>();
            }

            DontDestroyOnLoad(go);
            _instans = go.GetComponent<GameManager>();
        }
    }


}
