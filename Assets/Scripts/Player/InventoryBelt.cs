using System.Collections.Generic;
using UnityEngine;

public class InventoryBelt : MonoBehaviour
{
    public List<Tool> items = new List<Tool>(); 
    public int currentItemIndex = 0; 

    public GameObject emptyHandModel; 

    public GameObject handheldItem; 

    private void Start()
    {
        UpdateHandheldItem();
    }

    private void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0f)
        {
            currentItemIndex = (currentItemIndex + 1) % items.Count;
            UpdateHandheldItem();
        }
        else if (scroll < 0f)
        {
            currentItemIndex = (currentItemIndex - 1 + items.Count) % items.Count;
            UpdateHandheldItem();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            currentItemIndex = 0;
            UpdateHandheldItem();
        }
    }

    private void UpdateHandheldItem()
    {
        if (handheldItem != null)
        {
            Destroy(handheldItem);
        }

        Tool currentItem = items[currentItemIndex];

        if (currentItem != null)
        {
            handheldItem = Instantiate(currentItem.Equip(), transform);
        }
        else
        {
            handheldItem = Instantiate(emptyHandModel, transform);
        }
    }
}