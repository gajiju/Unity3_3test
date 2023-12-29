using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{


    

    Stats player_Stats = Stats.Idel;
    float radio = 0;

    public void Update()
    {
        switch(player_Stats)
        {
            case Stats.Idel:
                Player_Idel();
                break;
            case Stats.Attack:
                Player_Attack();
                break;
        }

    }

    public void Player_Attack()
    {
        player_Stats = Stats.Attack;
        radio = Mathf.Lerp(radio, 1, 10.0f * Time.deltaTime);
        Animator anim = GetComponent<Animator>();
        anim.SetFloat("Idel_Attack_radio",1);
        anim.Play("Attack");
    }
    public void Player_Idel()
    {
        radio = Mathf.Lerp(radio, 0, 10.0f * Time.deltaTime);
        Animator anim = GetComponent<Animator>();
        anim.SetFloat("Idel_Attack_radio", 0);
        anim.Play("Idel");
    }

}
public enum Stats
{
    Idel,
    Attack
}