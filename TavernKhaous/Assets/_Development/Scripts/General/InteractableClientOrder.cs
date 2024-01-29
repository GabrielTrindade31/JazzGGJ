using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableClientOrder : MonoBehaviour, IInteractable
{
    public virtual void Interact()
    {
        // Call dialog
        Debug.Log("Dialog");
    }
}
