using UnityEngine;
using System.Collections;
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

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }
}
