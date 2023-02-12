using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ButtonManage : MonoBehaviour
{
    public Transform player;
    
    public void ResetButton()
    {
        player.localRotation = Quaternion.identity;
        player.localPosition = Vector3.zero;
        player.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
    }
}
