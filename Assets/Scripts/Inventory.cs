using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Item[] items; // Массив предметов в инвентаре
    public int currentItemIndex = 0; // Индекс текущего выбранного предмета

    public GameObject emptyHandModel; // Модель для пустой руки

    private GameObject handheldItem; // Модель текущего предмета в руке

    private void Start()
    {
        // Устанавливаем пустую руку в начале игры
        UpdateHandheldItem();
    }

    private void Update()
    {
        // Изменение предмета в руке с помощью скролла колесика мыши
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0f)
        {
            // Скролл вверх - выбираем следующий предмет
            currentItemIndex = (currentItemIndex + 1) % items.Length;
            UpdateHandheldItem();
        }
        else if (scroll < 0f)
        {
            // Скролл вниз - выбираем предыдущий предмет
            currentItemIndex = (currentItemIndex - 1 + items.Length) % items.Length;
            UpdateHandheldItem();
        }

        // Убрать предмет в инвентарь, оставив руку пустой
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentItemIndex = 0; // Устанавливаем индекс пустой руки
            UpdateHandheldItem();
        }
    }

    private void UpdateHandheldItem()
    {
        // Удаляем предыдущий предмет из руки
        if (handheldItem != null)
        {
            Destroy(handheldItem);
        }

        // Получаем текущий предмет в руке
        Item currentItem = items[currentItemIndex];

        // Если текущий предмет не является пустой рукой, создаем его модель
        if (currentItem != null)
        {
            handheldItem = Instantiate(currentItem.model, transform);
        }
        else
        {
            // Иначе, устанавливаем модель пустой руки
            handheldItem = Instantiate(emptyHandModel, transform);
        }
    }
}

[System.Serializable]
public class Item
{
    public string name; // Название предмета
    public GameObject model; // Модель предмета (может быть пустым, если предмет не имеет связанной модели)
}