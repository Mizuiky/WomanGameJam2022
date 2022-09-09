using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    [SerializeField]
    private SO_Dialog _soDialog;

    [SerializeField]
    private DialogPanel _dialogPanel;

    public void StartDialog()
    {
        if (!DialogManager.Instance.ISWriting)
            DialogManager.Instance.Initialize(_soDialog);
    }
}
