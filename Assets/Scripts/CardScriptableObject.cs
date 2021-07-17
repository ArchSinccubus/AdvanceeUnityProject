using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Card",menuName = "Cards", order = 1)]
public class CardScriptableObject : ScriptableObject
{
    public int Number;
    public Sprite Image;
    public string Description;
}
