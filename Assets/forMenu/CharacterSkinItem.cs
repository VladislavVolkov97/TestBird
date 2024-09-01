
using UnityEngine;

[CreateAssetMenu(fileName ="CharacterSkinItem", menuName = "Shop/CharacterSkinsItem")]
public class CharacterSkinItem : ShopItem
{
   [field: SerializeField] public CharacterSkins SkinType { get; private set; }
}
