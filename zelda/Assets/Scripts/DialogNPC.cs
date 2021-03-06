using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNPC : Interactable
{
    //Reference to the intermediate dialog value
    [SerializeField]private TextAssetValue dialogValue;
    [SerializeField]private TextAsset myDialog;
    [SerializeField]private Notification branchingDialogNotification;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    if(playerInRange)
    {
        if(Input.GetButtonDown("Check"))
        {
            dialogValue.value = myDialog;
            branchingDialogNotification.Raise();
        }
    }
    }
}
