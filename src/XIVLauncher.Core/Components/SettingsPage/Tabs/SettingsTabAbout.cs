using System.Numerics;

using ImGuiNET;

using XIVLauncher.Common.Util;

namespace XIVLauncher.Core.Components.SettingsPage.Tabs;

public class SettingsTabAbout : SettingsTab
{
    private readonly TextureWrap logoTexture;

    public override SettingsEntry[] Entries => Array.Empty<SettingsEntry>();

    public override string Title => "About";

    public SettingsTabAbout()
    {
        this.logoTexture = TextureWrap.Load(AppUtil.GetEmbeddedResourceBytes("logo.png"));
    }

    public override void Draw()
    {
        ImGui.Image(this.logoTexture.ImGuiHandle, new Vector2(256) * ImGuiHelpers.GlobalScale);

        ImGui.Text($"XIVLauncher Core v{AppUtil.GetAssemblyVersion()}({AppUtil.GetGitHash()})");
        ImGui.Text("By goaaats & Bluefissure");

        if (ImGui.IsItemClicked(ImGuiMouseButton.Left))
            AppUtil.OpenBrowser("https://github.com/goaaats");

        ImGui.Dummy(new Vector2(20));

        if (ImGui.Button("Open Repository"))
        {
            AppUtil.OpenBrowser("https://github.com/ottercorp/XIVLauncher.Core");
        }

        if (ImGui.Button("Join our QQ Guild"))
        {
            AppUtil.OpenBrowser("https://pd.ottercorp.net");
        }

        if (ImGui.Button("See Software Licenses"))
        {
            PlatformHelpers.OpenBrowser(Path.Combine(AppContext.BaseDirectory, "license.txt"));
        }

        base.Draw();
    }
}
