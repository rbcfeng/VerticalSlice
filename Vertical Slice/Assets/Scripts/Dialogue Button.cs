using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
public class DialogueButton : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerText;
    [SerializeField] private Button _button;

    public void SetUpButton (PlayerReplies reply)
    {
        _playerText = reply.line;
        _button.onClick.AddListener(delegate
        {
            DialogueAdvancer._Instance.ChooseDialogue(reply.nextNode);
        });
    }
}
