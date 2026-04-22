using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    [SerializeField] private GameObject _npcDialogue;
    [SerializeField] private GameObject _playerChoices;
    [SerializeField] private TMP_Text _reply1;
    [SerializeField] private TMP_Text _reply2;
    [SerializeField] private TMP_Text _reply3;

public void ShowPlayerReplies(string[] replies)
    {
        _playerChoices.SetActive(true);
        _reply1.transform.parent.gameObject.SetActive(true);
        _reply1.text = replies[0];

        if(replies.Length >= 2)
        {
            _reply2.transform.parent.gameObject.SetActive(true);
            _reply2.text = replies[1];
        }
        else
        {
            _reply2.transform.parent.gameObject.SetActive(false);
        }
        if(replies.Length >= 3)
        {
            _reply3.transform.parent.gameObject.SetActive(true);
            _reply3.text = replies[2];
        }
        else
        {
            _reply3.transform.parent.gameObject.SetActive(false);
        }
    }


}
