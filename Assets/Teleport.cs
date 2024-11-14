using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject playerOrigin;
    [SerializeField]
    private LayerMask teleportMask;
    [SerializeField]
    private InputActionReference teleportButtonPress;

    void Start()
    {
        teleportButtonPress.action.performed += DoRaycast;

    }

    void DoRaycast(InputAction.CallbackContext __)
    {
        RaycastHit hit;
        bool didHit = Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, teleportMask);
        // Does the ray intersect any objects excluding the player layer
        // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
        if (didHit)
        {
            playerOrigin.transform.position = hit.collider.gameObject.transform.position;
        }
    }

}
