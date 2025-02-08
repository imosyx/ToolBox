using Swed32;
using ToolBox;



Renderer renderer = new Renderer(); // create instance of menu with overlay
renderer.Start().Wait(); // run it
Console.WriteLine("No issues found !");


Swed swed = new Swed("kogama");
IntPtr moduleBase = swed.GetModuleBase("GameAssembly.dll");
Console.WriteLine("Attached to Kogama");

//Features!!
IntPtr EditMuzzleNoBoundsAddress = moduleBase + 0x50D1D0; // EditMuzzleNoBoundss
IntPtr NoDeleteLimit = moduleBase + 0x453091; // no delete limit
IntPtr NeverCrushed = moduleBase + 0x294870; // never crushed
IntPtr NoBlueModeAddress = moduleBase + 0x244F0B; // No blue mode
IntPtr NoBuildLimitAddress = moduleBase + 0x4524AC; // No build limit


while (true)
{
    if (renderer.NoBlueMode)
    {
        swed.WriteBytes(NoBlueModeAddress, "30 DB 90");
    }
    else
    {
        swed.WriteBytes(NoBlueModeAddress, "88 5E 50");
    }

    if (renderer.NoBuildLimit)
    {
        swed.WriteBytes(NoBuildLimitAddress, "31 C0 90");
    }
    else
    {
        swed.WriteBytes(NoBuildLimitAddress, "8B 45 10");
    }

    if (renderer.EditMuzzleNoBounds)
    {
        swed.WriteBytes(EditMuzzleNoBoundsAddress, "B0 01 C3");
}
    else
    {
        swed.WriteBytes(EditMuzzleNoBoundsAddress, "53 8B DC");
    }
    
    if (renderer.NoDeleteLimit)
    {
        swed.WriteBytes(NoDeleteLimit, "31 C0 90 90 90 90 90 90");
    }
    else
    {
        swed.WriteBytes(NoDeleteLimit, "85 C0 0F 85 0B 01 00 00");
    }

    if (renderer.NeverCrushed)
    {
        swed.WriteBytes(NeverCrushed, "B0 00");
    }
    else
    {
        swed.WriteBytes(NeverCrushed, "B0 01");
    }
    Thread.Sleep(20);
}