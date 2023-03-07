//Thanks to Demonixis
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public sealed class TranslateText : MonoBehaviour
{
    //Attach to any GameObject with Text
    [SerializeField]
    private string m_Key = null;
    private void Start()
    {
        var text = GetComponent<Text>();
        text.text = Translation.Get(m_Key != string.Empty ? m_Key : text.text);
        Destroy(this);
    }
}