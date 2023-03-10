using UnityEngine;
using UnityEngine.EventSystems;

public class DefaultSelectedButton : MonoBehaviour
{
    [SerializeField] GameObject DefaultButton;
    [SerializeField] GameObject SecondaryButton;
    bool changed = false;

    private void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if ((EventSystem.current.currentSelectedGameObject != DefaultButton && !changed) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            SelectDefaultButton();
            changed = true;
        }
    }

    public void SelectDefaultButton()
    {
        //Clear selected object
        EventSystem.current.SetSelectedGameObject(null);


        //set a new selected object
        if (DefaultButton.activeSelf)
            EventSystem.current.SetSelectedGameObject(DefaultButton);
        else
            EventSystem.current.SetSelectedGameObject(SecondaryButton);
    }

    private void OnDisable()
    {
        changed = false;
    }

    private void OnEnable()
    {
        SelectDefaultButton();
        changed = false;
    }
}
