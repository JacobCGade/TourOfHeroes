using ToH.Data;
using ToH.Log;

namespace ToH.PL.Screens;

public class HeroScreen : Screen
{
    public Hero Hero { get; set; }
    private readonly IPrinter _printer;
    private readonly ILog _log;

    public HeroScreen(Hero hero, IPrinter printer, Log.ILog log)
    {
        Hero = hero;
        _printer = printer;
        _log = log;
    }

    public override void Init()
    {
        _printer.Clear();
        _log.Debug($"HeroScreen.Init: Showing hero {Hero.Id}.");
        _printer.PrintLine("Hero details");
        _printer.PrintLine("");
        _printer.PrintLine($"Id: {Hero.Id}");
        _printer.PrintLine($"Name: {Hero.Name?.ToUpper()}");
    }

    public override void Escape(IUi ui)
    {
        _log.Info($"HeroScreen.Escape: Switching to HeroesListScreen.");
        var newScreen = ui.ScreenFactory?.CreateScreen(typeof(HeroesListScreen));
        if (newScreen != null)
        {
            ui.Screen = newScreen;
        }
    }
}