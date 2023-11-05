using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPlate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player.Instance.PlayerWin();
    }
}
