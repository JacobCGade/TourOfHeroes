using ToH.PL.Screens;

namespace ToH.PL;

public interface IUi
{
    Screen? Screen { set; }
    IScreenFactory? ScreenFactory { get; }
}