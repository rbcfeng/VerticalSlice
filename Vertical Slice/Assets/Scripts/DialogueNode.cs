using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/Dialogue Asset")]
public class DialogueNode : ScriptableObject
{
  
    public string[] _lines;
    public string[] _playerReplies;
    public NextNode[] _nextnode;

}