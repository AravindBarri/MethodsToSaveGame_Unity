using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Windows;

public class DemoSaveMethods : MonoBehaviour
{
    string time = System.DateTime.Now.ToString();
    string systemname;
    string systemresolution;
    string systemMemory;

    private void Start()
    {
        string systemname = Environment.MachineName.ToString();
        string systemresolution = Screen.currentResolution.ToString();
        string systemMemory = SystemInfo.systemMemorySize.ToString();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SetPlayerData();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetPlayerData();
        }
    }
    void SetPlayerData()
    {
        /*PlayerPrefs.SetInt("Score", 10000);
        print("Data Saved");
        PlayerPrefs.SetString("PlayerName", "Aravind");
        PlayerPrefs.SetString("Time", System.DateTime.Now.ToString());*/

        string filepath = Application.persistentDataPath + "/Myfile.file";
        //StreamWriter sw = new StreamWriter(filepath);

        FileStream fs = new FileStream(filepath,FileMode.OpenOrCreate);
        BinaryWriter sw = new BinaryWriter(fs);
        sw.Write(123214324.0909148f);
        sw.Write(time);
        fs.Close();
        sw.Close();
        //print(System.DateTime.Now.TimeOfDay);
    }

    void GetPlayerData()
    {
        /*print(PlayerPrefs.GetInt("Score"));
        print(PlayerPrefs.GetString("PlayerName"));
        print(PlayerPrefs.GetString("Time"));*/
        string filepath = Application.persistentDataPath + "/Myfile.file";
        StreamReader sr = new StreamReader(filepath);
        print(sr.ReadLine());
        sr.Close();
    }
    
}
