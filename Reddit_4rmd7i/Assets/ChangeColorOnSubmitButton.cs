using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ChangeColorOnSubmitButton : MonoBehaviour
{
    public MeshRenderer MeshRenderer
    {
        get { return _meshRenderer ?? (_meshRenderer = GetComponent<MeshRenderer>()); } // Obtain our MeshRenderer
    }
    private MeshRenderer _meshRenderer;

	// Use this for initialization
	void Start()
	{
	    EventController.Instance.OnClick += OnClick; // Listen for all "OnClick" Actions passed
	    ToggleColor();
	}

    private void OnClick(string var)
    {
        if (var != "Submit") return; // Ignore "OnClick" Actions that are not "Submit"
        ToggleColor();
    }

    private bool _isRed;

    private void ToggleColor()
    {
        if (MeshRenderer != null)
        {
            if (_isRed)
            {
                MeshRenderer.material.color = Color.green;
                _isRed = false;
            }
            else
            {
                MeshRenderer.material.color = Color.red;
                _isRed = true;
            }
        }
    }
}
