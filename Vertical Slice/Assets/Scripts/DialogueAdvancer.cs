using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueAdvancer : MonoBehaviour
{
    [SerializeField] private DialogueNode _dialogueNode;
    [SerializeField] private DialogueNode line;
    //[SerializeField] private TMP_Text _reply1;
   // [SerializeField] private TMP_Text _reply2;
//    [SerializeField] private TMP_Text _reply3;
    public static DialogueAdvancer _Instance {get; private set;}

    private void Awake()
    {
        if (_Instance != null && _Instance != this)
        {
            Destroy(this);
            return;
        }

        _Instance = this;
    }
    
     public void ChooseDialogue (DialogueNode nextLine)
    {
        EventBus.Trigger(EventNames.NewDialogueEvent, nextLine);
        
    }

    private void Start()
    {
        EventBus.Trigger(EventNames.NewDialogueEvent, _dialogueNode);
    }
}
