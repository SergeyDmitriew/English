using UnityEngine;
using UnityEngine.UI;

public class GameText : MonoBehaviour
{
    [SerializeField] private Text _textBack;
    [SerializeField] private Text _textFront;

    [SerializeField] private Color _colorHide = Color.white;
    [SerializeField] private Color _colorShow = new Color (1.0f, 1.0f, 1.0f, 0.1f);

    private bool _isShow;

    public bool IsShow
    {
        get { return _isShow; }
        set
        {
            if (value) Show ();
            else Hide ();
        }
    }

    public void SetText (string value)
    {
        _textFront.text = value;
        _textBack.text = value;
    }

    public void Show ()
    {
        _textFront.color = _colorShow;
        _isShow = true;
    }

    public void Hide ()
    {
        _textFront.color = _colorHide;
        _isShow = false;
    }
}