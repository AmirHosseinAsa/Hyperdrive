using UnityEngine;
using UnityEngine.UI;

public class Quick_Race_Settings_Selection : MonoBehaviour
{
    [SerializeField] Button back_Quick_Race_1P, back_Quick_Race_2P, next;
    [SerializeField] GameObject car1, car5;

    public static bool isMultiplayer = false;
    private bool oldValue = false;

    void Update()
    {
        if (isMultiplayer != oldValue)
        {
            Navigation nextNavigation = next.navigation;
            nextNavigation.mode = Navigation.Mode.Explicit;
            if (isMultiplayer)
                nextNavigation.selectOnLeft = back_Quick_Race_2P;
            else
                nextNavigation.selectOnLeft = back_Quick_Race_1P;
            next.navigation = nextNavigation;
            oldValue = isMultiplayer;
        }
    }
}
