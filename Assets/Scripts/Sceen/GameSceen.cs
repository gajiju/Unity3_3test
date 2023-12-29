using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceen : BaseSceen
{
    protected override void Init()
    {
        base.Init();

        Scenetype = Utill.Scenes.Game;

        GameManager.Resource.Instantiate("UI/UI_Main");
        GameManager.Resource.Instantiate("UI/UserInfo");
    }
}
