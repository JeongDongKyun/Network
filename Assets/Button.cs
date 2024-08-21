using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using TMPro;

public class Button : MonoBehaviour
{
    [SerializeField] private Network network = null;
    [SerializeField] private TMP_InputField input_text = null;

    public void MadeRoom()
    {
        Debug.Log("¹æ »ý¼º!");

        network.StartHost();
    }

    public void JoinRoom()
    {
        network.networkAddress = input_text.text;

        network.StartClient();

        Debug.Log(input_text.text);
    }
}