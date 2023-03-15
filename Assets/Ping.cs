using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ping : MonoBehaviour
{
    string message = string.Empty;
    string ping = "Ping";
    string pong = "Pong";
    // Start is called before the first frame update
    void Start()
    {
        message = ping;
    }

    // Update is called once per frame
    void Update()
    {
        if (message == ping)
        {
            message = pong;
            Debug.Log(message);
        }
    }
}
