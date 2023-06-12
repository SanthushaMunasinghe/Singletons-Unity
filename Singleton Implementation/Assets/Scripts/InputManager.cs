using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    public string Shoot()
    {
        return "Shooting";
    }
    
    public string Jump()
    {
        return "Jumping";
    }
}
