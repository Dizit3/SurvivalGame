using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance { get; private set; }

    public List<GameObject> items = new List<GameObject>(); // Список предметов в инвентаре

    public event Action OnItemAdding;

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

    public void AddItem(GameObject gameItem)
    {
        items.Add(gameItem);
        Debug.Log("Added item: " + gameItem.GetComponent<Item>().itemName);
        OnItemAdding?.Invoke();
    }

    public void RemoveItem(GameObject gameItem)
    {
        items.Remove(gameItem);
        Debug.Log("Removed item: " + gameItem.GetComponent<Item>().itemName);
    }
}
