using UnityEngine;
using UnityEngine.UI;
    public class LenguageManager : MonoBehaviour
{
    public ScriptableLanguage español;
    public ScriptableLanguage catalan;
    public ScriptableLanguage ingles;

    public Text texto1;
    public Text texto2;
    public Text texto3;
    public Text texto4;

    public void CambiarIdioma(ScriptableLanguage idioma)
    {
        texto1.text = idioma.texto1;
        texto2.text = idioma.texto2;
        texto3.text = idioma.texto3;
        texto4.text = idioma.texto4;
    }

    public void Español() => CambiarIdioma(español);
    public void Catalan() => CambiarIdioma(catalan);
    public void Ingles() => CambiarIdioma(ingles);
}
