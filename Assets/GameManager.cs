using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float score;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }
}
