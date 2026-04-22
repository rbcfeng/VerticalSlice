using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAdvancer : MonoBehaviour
{
    [SerializeField] private DialogueNode line;
     public void ChooseDialogue ()
    {
        EventBus.Trigger(EventNames.NewDialogueEvent, line);
    }
}
