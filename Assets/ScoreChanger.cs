using UnityEngine;
using System.Collections;
public class ScoreChanger : MonoBehaviour
{
    private void OnGUI()
    {
        if(GUI.Button(new Rect(10,100,100,30), "Add Score"))
        {
            GameManager.instance.score++;
        }
        if(GUI.Button(new Rect(120, 100, 100, 30), "Subtract Score"))
        {
            GameManager.instance.score--;
        }
        if (GUI.Button(new Rect(10, 130, 100, 30), "Add level"))
        {
            GameManager.instance.level++;
        }
        if (GUI.Button(new Rect(120, 130, 100, 30), "Subtract level"))
        {
            GameManager.instance.level--;
        }
        if (GUI.Button(new Rect(10, 160, 100, 30), "Add xp"))
        {
            GameManager.instance.xp++;
        }
        if (GUI.Button(new Rect(120, 160, 100, 30), "Subtract xp"))
        {
            GameManager.instance.xp--;
        }
        if (GUI.Button(new Rect(250, 100, 100, 30), "save"))
        {
            GameManager.instance.Save();
        }
        if (GUI.Button(new Rect(350, 100, 100, 30), "load"))
        {
            GameManager.instance.Load();
        }
    }
}
