//script to trigger that the player have finish the level
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
   public GameMaster gm;

    //show the winning UI
    void OnCollisionEnter2D()
    {
        gm.End();
    }
}
