using UnityEngine;

public class InventoryGrid : MonoBehaviour
{
    public GameObject slotPrefab;
    public Transform slotsParent;


    private void Start()
    {
        Inventory.Instance.OnItemAdding += RefreshInventory;
    }


    public void RefreshInventory()
    {
        Transform parentTransform = transform;

        for (int i = parentTransform.childCount - 1; i >= 0; i--)
        {
            Destroy(parentTransform.GetChild(i).gameObject);
        }

        foreach (var item in Inventory.Instance.items)
        {
            Instantiate(slotPrefab, slotsParent);
        }
    }
}