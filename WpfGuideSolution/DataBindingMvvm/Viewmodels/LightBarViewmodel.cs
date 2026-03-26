using CommunityToolkit.Mvvm.ComponentModel;

namespace DataBindingMvvm.Viewmodels;

public class LightBarViewmodel : ObservableObject
{
    private int _distanceBetweenPointsLightBar = 10;
    private int _distanceAlignmentLightBar = 5;

    public int DistanceBetweenPointsLightBar
    {
        get => _distanceBetweenPointsLightBar;
        set => SetProperty(ref _distanceBetweenPointsLightBar, value);
    }

    public int DistanceAlignmentLightBar
    {
        get => _distanceAlignmentLightBar;
        set => SetProperty(ref _distanceAlignmentLightBar, value);
    }
}