using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputManager inputManager;

    private void Start()
    {
        inputManager = InputManager.instance;
    }

    public void OnShoot()
    {
        Debug.Log(inputManager.Shoot());
    }

    public void Jump()
    {
        Debug.Log(inputManager.Jump());
    }
}
