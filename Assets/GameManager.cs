using UnityEngine;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
public class GameManager : MonoBehaviour
{
    public float score;
    public float level;
    public float xp;
    public static GameManager instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if(instance!= this)
        {
         Destroy(gameObject); 
        }

    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 30, 100, 30), "Score:" + score);
        GUI.Label(new Rect(10, 50, 100, 30), "level:" + level);
        GUI.Label(new Rect(10, 70, 100, 30), "xp:" + xp);

    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        PlayerData data = new PlayerData();
        data.score = score;
        data.level = level;
        data.xp = xp;
        bf.Serialize(file, data);
        file.Close();
    }
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close() ;
            score = data.score;
            level = data.level;
            xp = data.xp;
        }
    }

    [Serializable]
    class PlayerData
    {
        public float score;
        public float level;
        public float xp;
    }  
}
