using UnityEngine;
using UnityEngine.UI;

namespace Core.Screen
{
    public class ScreenView : MonoBehaviour
    {
        [SerializeField] private Button _buttonTrue;
        [SerializeField] private Button _buttonFalse;
        [SerializeField] private Button _buttonAnswer;
        [SerializeField] private Text _textQuestion;
        [SerializeField] private Text _textAnswer;
    }
}