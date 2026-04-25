using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueAdvancer : MonoBehaviour
{
    [SerializeField] private DialogueNode line;
    [SerializeField] private TMP_Text _reply1;
    [SerializeField] private TMP_Text _reply2;
    [SerializeField] private TMP_Text _reply3;
    
     public void ChooseDialogue ()
    {
        EventBus.Trigger(EventNames.NewDialogueEvent, line);
        _reply1.transform.parent.gameObject.SetActive(false);
        _reply2.transform.parent.gameObject.SetActive(false);
        _reply3.transform.parent.gameObject.SetActive(false);
    }
}
