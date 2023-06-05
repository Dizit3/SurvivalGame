using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance { get; private set; }

    public List<Item> items = new List<Item>(); // Список предметов в инвентаре

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    public void AddItem(Item item)
    {
        items.Add(item);
        Debug.Log("Added item: " + item.name);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
        Debug.Log("Removed item: " + item.name);
    }
}
