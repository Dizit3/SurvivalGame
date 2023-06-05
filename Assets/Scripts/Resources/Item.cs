using UnityEngine;

public abstract class Item : MonoBehaviour , IPickable
{
    public string itemName;
    //public Sprite icon;
    public int cost;

    public abstract GameObject Pick();
}
