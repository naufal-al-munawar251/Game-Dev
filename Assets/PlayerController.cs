using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController character;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 kuadrat = new Vector3(Input.GetAxis("Horizontal"), -5.0f * Time.deltaTime, Input.GetAxis("Vertical"));
        if(kuadrat != Vector3.zero)
        {
            
        }
        character.Move(kuadrat * Time.deltaTime * 5.0f);
    }
}
