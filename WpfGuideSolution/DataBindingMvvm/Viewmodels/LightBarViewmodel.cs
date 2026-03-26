using CommunityToolkit.Mvvm.ComponentModel;

namespace DataBindingMvvm.Viewmodels;

public class LightBarViewmodel : ObservableObject
{
    private int _distanceBetweenPointsLightBar = 5;

    public int DistanceBetweenPointsLightBar
    {
        get => _distanceBetweenPointsLightBar;
        set => SetProperty(ref _distanceBetweenPointsLightBar, value);
    }
}