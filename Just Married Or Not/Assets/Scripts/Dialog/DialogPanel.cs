using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogPanel : MonoBehaviour
{
   [SerializeField]
   private SO_Dialog _soDialog;

    [SerializeField]
    private EndDialogBase _endDialog;

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        gameObject.SetActive(false);
        _soDialog._endPrefab = _endDialog;
    }

    public void StartDialog()
    {
        gameObject.SetActive(true);

        if (!DialogManager.Instance.ISWriting)
            DialogManager.Instance.Initialize(_soDialog);      
    }
}
