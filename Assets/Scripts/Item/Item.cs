using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemData itemData; 

    // 외부에서 이 아이템이 어떤 데이터인지 읽을 때 사용하는 프로퍼티
    public ItemData Data  => itemData;

    // public string GetName()        => itemData != null ? itemData.ItemName : "NoName";
    // public Sprite GetIcon()        => itemData != null ? itemData.Icon : null;
    // public string GetDescription() => itemData != null ? itemData.Description : "";
}
