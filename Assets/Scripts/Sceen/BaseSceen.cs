using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BaseSceen : MonoBehaviour
{
    public Utill.Scenes Scenetype { get; protected set; } = Utill.Scenes.Unknown;

    private void Awake()
    {
        Init();
        
    }

    protected virtual void Init()
    {
        object obj = GameObject.FindObjectOfType(typeof(EventSystem));
        if(obj == null)
        {
            GameManager.Resource.Instantiate("UI/EventSystem").name = "@EventSystem";
        }
    }


}
