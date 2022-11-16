using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandle : MonoBehaviour
{
    
    public void StartUpdateEvents()
    {
        Debug.Log("UpdateEvents");

        if (counter == 15)
        {
            Notification.text = "New Goal 15 XP"
            Debug.Log("New Goal 15 XP - Event Reached")
            PlayerPrefs.SetString("Logros", Notification.text);
        }

        if (counter == 15)
        {
            Notification.text = "New Goal 25 XP"
            Debug.Log("New Goal 25 XP - Event Reached")
            PlayerPrefs.SetString("Logros", Notification.text);
        }
            
    }
    public void LeaveGame()
    {
        PlayerPrefs.GetInt("Points", counter);
        SceneManager.LoadScene("LeaderBoard");
    }
}
