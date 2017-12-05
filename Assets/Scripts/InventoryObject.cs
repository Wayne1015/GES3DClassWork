using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable {
    [SerializeField]
    private string nameText;

    [SerializeField]
    private string DescriptionText;

    private MeshRenderer meshRenderer;
    private Collider collider;
    private List<InventoryObject> playerInventory;
    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void DoActivate()
    {
        playerInventory.Add(this);
        meshRenderer.enabled = false;
        collider.enabled = false;
    }

    // Use this for initialization
    void Start () {
        collider = GetComponent<Collider>();
        meshRenderer = GetComponent<MeshRenderer>();
        playerInventory = FindObjectOfType<InventoryMenu>().PlayerInventory;
	}
	
	
}
