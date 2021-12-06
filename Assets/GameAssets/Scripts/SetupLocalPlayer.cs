using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour
{
    [SyncVar] public string playerName;
    [SyncVar] public Color playerColor;

    [SerializeField]
    Text playerNameTxt;

    void Start()
    {
        playerNameTxt.text = playerName;
        playerNameTxt.color = playerColor;
        GetComponentInChildren<Renderer>().material.color = playerColor;
       
    }

    
    
}
