using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleOutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.logMessageReceived += HandleLog;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Test");
    }

    void HandleLog(string logString, string stackTrace, LogType type) 
    {
        logString += '\n';
        gameObject.GetComponent<Text>().text = logString; 
    }
}
