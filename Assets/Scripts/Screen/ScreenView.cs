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

        public void Initialize(IScreenListener screenListener)
        {
            _buttonTrue.onClick.AddListener(screenListener.OnClickTrue);
            _buttonFalse.onClick.AddListener(screenListener.OnClickFalse);
            _buttonAnswer.onClick.AddListener(screenListener.OnClickAnswer);
        }

        public void ShowQuestion(string message)
        {
            _textQuestion.text = message;

            SetTextsEnable(false, true);
            SetButtonsEnable(true, false, false);
        }

        public void ShowAnswer(string message)
        {
            _textAnswer.text = message;

            SetTextsEnable(true, true);
            SetButtonsEnable(false, true, true);
        }

        private void SetTextsEnable(bool textAnswer, bool textQuestion)
        {
            _textAnswer.enabled = textAnswer;
            _textQuestion.enabled = textQuestion;
        }

        private void SetButtonsEnable(bool buttonAnswer, bool buttonTrue, bool buttonFalse)
        {
            _buttonTrue.gameObject.SetActive(buttonTrue);
            _buttonFalse.gameObject.SetActive(buttonFalse);
            _buttonAnswer.gameObject.SetActive(buttonAnswer);
        }
    }
}