using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceenManager
{
   public BaseSceen currentScene { get { return GameObject.FindObjectOfType<BaseSceen>(); } }

    string GetSceneName(Utill.Scenes type)
    {
        string name = Enum.GetName(typeof(Utill.Scenes), type);
        return name;
    }

    public void LoadScene(Utill.Scenes type)
    {
        SceneManager.LoadScene(GetSceneName(type));
    }
}
