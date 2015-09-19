﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Game : MonoBehaviour {

    public Canvas inventoryCanvas;

    public Button inventoryToggle;

    // Use this for initialization
	void Start () {
        inventoryToggle = inventoryToggle.GetComponent<Button>();

        inventoryToggle.onClick.AddListener(ToggleInventory);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    // show/hide the inventory
    void ToggleInventory()
    {
        inventoryCanvas.gameObject.SetActive(!inventoryCanvas.gameObject.activeSelf);
        Debug.Log("Inventory toggled...");
    }
}
