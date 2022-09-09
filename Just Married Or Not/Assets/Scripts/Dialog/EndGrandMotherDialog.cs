using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGrandMotherDialog : EndDialogBase
{
    public override void EndCallBack()
    {
        base.EndCallBack();

        gameObject.SetActive(true);
    }
}
