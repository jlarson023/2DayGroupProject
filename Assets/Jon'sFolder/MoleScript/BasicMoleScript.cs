using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMoleScript : Clickable
{
    public bool isHurt = false;
    
    protected override void GotClicked()
    {
        if (!isHurt)
        {
            base.GotClicked();
            //play animation
            Destroy(gameObject, 3);
            isHurt = true;
        }
    }
}
