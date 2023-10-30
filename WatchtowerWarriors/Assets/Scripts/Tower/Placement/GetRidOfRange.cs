using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRidOfRange : MonoBehaviour
{
    [SerializeField] private SpriteRenderer rangeDisplay;
    void Start()
    {
        rangeDisplay = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetAxisRaw("Fire1") >= 0.1f) { rangeDisplay.enabled = false; }
    }
}
