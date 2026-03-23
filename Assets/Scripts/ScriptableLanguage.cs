using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObjects/Items")]
public class ScriptableLanguage : ScriptableObject
{
    public string languageName;
    public string languageDescription;
    public Sprite languageSprite;
}
