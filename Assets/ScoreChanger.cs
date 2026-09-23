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
        if (GUI.Button(new Rect(10, 120, 100, 30), "Add level"))
        {
            GameManager.instance.level++;
        }
        if (GUI.Button(new Rect(120, 120, 100, 30), "Subtract level"))
        {
            GameManager.instance.level--;
        }
        if (GUI.Button(new Rect(10, 140, 100, 30), "Add xp"))
        {
            GameManager.instance.xp++;
        }
        if (GUI.Button(new Rect(120, 140, 100, 30), "Subtract xp"))
        {
            GameManager.instance.xp--;
        }
    }
}
