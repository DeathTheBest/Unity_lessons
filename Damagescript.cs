using Microsoft.SqlServer.Server;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagescript : MonoBehaviour
{
    public int damage = 5;      // количество наносимого урона
    private void OnCollisionEnter(Collision collision)
    {
      player playerScript = collision.gameObject.GetComponent<player>();
        playerScript.updateLife (-damage);
    }



}
// https://prnt.sc/unm24m можно изменять в юнити
// прикретить на предмет который должен наносить урон 