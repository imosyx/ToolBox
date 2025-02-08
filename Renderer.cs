using ClickableTransparentOverlay;
using ImGuiNET;

namespace ToolBox
{
    public class Renderer : Overlay
    {
        //features
        public bool NoBlueMode = false;
        public bool NoBuildLimit = false;
        public bool EditMuzzleNoBounds = false;
        public bool NoDeleteLimit = false;
        public bool NeverCrushed = false;

        protected override void Render()
        {
            ImGui.Begin("ToolBox - kogama");
            ImGui.TextDisabled("made by imosyx");
            ImGui.Checkbox("No Blue Mode", ref NoBlueMode);
            ImGui.Checkbox("No Build Limit", ref NoBuildLimit);
            ImGui.Checkbox("EditMuzzleNoBounds", ref EditMuzzleNoBounds);
            ImGui.Checkbox("No Delete limit", ref NoDeleteLimit);
            ImGui.Checkbox("Never Crushed", ref NeverCrushed);



            ImGui.End();
        }
    }
}
