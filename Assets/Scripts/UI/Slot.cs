using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //public Image iconImage;

    private Item item;

    public void SetItem(Item newItem)
    {
        item = newItem;
        //iconImage.sprite = item.icon;
    }

    public void OnClick()
    {
        // Обработка щелчка по слоту, например, использование предмета или перемещение в инвентаре
    }
}