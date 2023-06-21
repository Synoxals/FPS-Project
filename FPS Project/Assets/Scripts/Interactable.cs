using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promptMessage;
    // Add or remove interaction Event component
    public bool useEvents;
    
    public void BaseInteract()
    {
        Interact(); 
    }
    protected virtual void Interact()
    {
        
    }
}
