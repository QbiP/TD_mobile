using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int Health;

    void takeDMG(int DMG)
    {
        Health -= DMG;
        if(Health <= 0)
        {
            this.gameObject.SendMessage("Dead");
        }
    }
}
