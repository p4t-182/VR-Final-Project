using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpHammer : MonoBehaviour
{
    [SerializeField]
    private GameObject hammerOrigin;
    [SerializeField]
    private LayerMask hammerMask;
    [SerializeField]
    private InputActionReference grabButtonPress;

    void Start()
    {
        grabButtonPress.action.performed += DoRaycast;

    }

    void DoRaycast(InputAction.CallbackContext __)
    {
        RaycastHit hit;
        bool didHit = Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, hammerMask);
        // Does the ray intersect any objects excluding the player layer
        // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
        if (didHit)
        {
            hammerOrigin.transform.position = hit.collider.gameObject.transform.position;
        }
    }
}
