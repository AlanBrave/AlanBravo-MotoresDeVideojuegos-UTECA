using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ava : MonoBehaviour
{
    public int AvatarIndex = 0
    public List<Avatar> Avatars;
    public TMP_Text Name;
    public TMP_Text Desc;
    public TMP_Text XP;
    void Start()
    {
        
    }

    
    void Update()
    {
        Name.text - Avatars[AvatarIndex].Name;
        Desc.text = "Information: " + Avatars[AvatarIndex].Description;
        XP.text - Avatars[AvatarIndex].XP.ToString() + ""XP";
    }
}
