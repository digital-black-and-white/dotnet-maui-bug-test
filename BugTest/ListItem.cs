
using CommunityToolkit.Mvvm.ComponentModel;

namespace BugTest;

public partial class ListItem(string name) : ObservableObject
{
    [ObservableProperty]
    private string _name = name;
}
