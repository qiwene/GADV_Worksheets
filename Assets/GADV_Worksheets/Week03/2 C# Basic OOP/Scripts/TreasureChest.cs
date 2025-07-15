using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public virtual void Unlock()
    {
        Debug.Log("You unlock the chest.");
    }

    public void Unlock(bool hasToken)
    {
        if (hasToken)
        {
            Debug.Log("You unlock the chest with bonus treasure!");
        }
        else
        {
            Unlock();
        }
    }

    public void Shake()
    {
        Debug.Log("You hear something rattle inside the chest");
    }
}
public class AncientChest : TreasureChest
{
    public override void Unlock()
    {
        Debug.Log("You unlock the chest with an ancient key");
    }
}

public class MagicChest : TreasureChest
{
    public override void Unlock()
    {
        Debug.Log("You cast a spell to unlock the magic chest.");
    }
}
