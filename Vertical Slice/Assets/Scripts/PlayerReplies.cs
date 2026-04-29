using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

[Serializable][Inspectable]
public class PlayerReplies : MonoBehaviour
{
   [Inspectable] public TMP_Text line;
   [Inspectable] public DialogueNode nextNode;

}
