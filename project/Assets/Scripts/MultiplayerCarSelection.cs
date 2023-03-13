using UnityEngine;
using UnityEngine.UI;

public class MultiplayerCarSelection : MonoBehaviour
{
    [SerializeField] Button previousCar, nextCar, back_play, back_quick_race, play, next;

    public static bool isMultiplayer = false;
    private bool oldValue = false;

    // Update is called once per frame
    void LateUpdate()
    {
        if (isMultiplayer != oldValue)
        {
            if (isMultiplayer)
            {
                Navigation previousCarNavigation = previousCar.navigation;
                previousCarNavigation.mode = Navigation.Mode.Explicit;
                previousCarNavigation.selectOnDown = back_quick_race;
                previousCar.navigation = previousCarNavigation;

                Navigation nextCarNavigation = nextCar.navigation;
                nextCarNavigation.mode = Navigation.Mode.Explicit;
                nextCarNavigation.selectOnDown = next;
                nextCar.navigation = nextCarNavigation;
            }
            else
            {
                Navigation previousCarNavigation = previousCar.navigation;
                previousCarNavigation.mode = Navigation.Mode.Explicit;
                previousCarNavigation.selectOnDown = back_play;
                previousCar.navigation = previousCarNavigation;

                Navigation nextCarNavigation = nextCar.navigation;
                nextCarNavigation.mode = Navigation.Mode.Explicit;
                nextCarNavigation.selectOnDown = play;
                nextCar.navigation = nextCarNavigation;
            }

            oldValue = isMultiplayer;
        }
    }
}
