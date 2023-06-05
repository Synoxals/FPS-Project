using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
    public GameObject Changed;
    public Vector3 activePosition = new Vector3(9, 3.5f, 4.2f);
    public int stairSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        
        Changed.transform.Translate(0 , 0, -2.8f);
    }
}
