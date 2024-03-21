using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    public Transform rightAttach;
    public Transform leftAttach;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = leftAttach;
        }
        else if(args.interactorObject.transform.CompareTag("RightHand"))
        {
            attachTransform = rightAttach;
        }

        base.OnSelectEntered(args);
    }
}
