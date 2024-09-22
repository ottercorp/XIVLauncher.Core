![xlcore_sized](https://user-images.githubusercontent.com/16760685/197423373-b6082cdb-dc1f-46db-8768-3f507f182ba8.png)

# XIVLauncher.Core

XIVLauncher 的跨平台版本，针对 Steam Deck 进行了优化。 附带一个 [为最终幻想 14 调整过的 WINE](https://github.com/goatcorp/wine-xiv-git).

[反馈频道](https://qun.qq.com/qqweb/qunpro/share?_wv=3&_wwv=128&inviteCode=CZtWN&from=181074&biz=ka&shareSource=5)

## 在 Steam Deck 上使用

如果您想在 Steam Deck 上使用 XIVLauncher，请随时[按照我们常见问题解答中的指南](https://aonyx.ffxiv.wang/faq/steamdeck)。 如果您遇到问题，可以[加入我们的反馈频道](<[https://discord.gg/3NMcUV5](https://qun.qq.com/qqweb/qunpro/share?_wv=3&_wwv=128&inviteCode=CZtWN&from=181074&biz=ka&shareSource=5)>) - 请不要使用 GitHub issues 进行故障排除，除非您确定您的问题是与 XIVLauncher 的代码相关。

## Building & Contributing

1. Clone this repository with submodules
2. Make sure you have a recent(.NET 6.0.400+) version of the .NET SDK installed
3. Run `dotnet build` or `dotnet publish`

Common components that are shared with the Windows version of XIVLauncher are linked as a submodule in the "lib" folder. XIVLauncher Core can run on Windows, but is by far not as polished as the [original Windows version](https://github.com/goatcorp/FFXIVQuickLauncher). Windows users should not use this application unless for troubleshooting purposes or development work.

## 分发

XIVLauncher Core 具有适用于各种 Linux 发行版的社区包。 请注意，**只有 Flathub 版本是官方版本**，但其他版本是由社区成员**打包**。 社区包可能并不总是最新的，或者可能有损坏的版本或包含正在测试的功能（特别是如果标记为不稳定或 git）。 我们对其安全性或可靠性不承担任何责任。

| 仓库                                                                                  | 状态                                                                                                                                                                                                                                                |
| ------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [**Flathub (official)**](https://flathub.org/apps/details/cn.ottercorp.xivlaunchercn) | ![Flathub](https://img.shields.io/flathub/v/cn.ottercorp.xivlaunchercn)                                                                                                                                                                             |
| [AUR](https://aur.archlinux.org/packages/xivlauncher-cn-git)                          | ![AUR version](https://img.shields.io/aur/version/xivlauncher-cn-git)                                                                                                                                                                               |
| [MPR (Debian+Ubuntu)](https://mpr.makedeb.org/packages/xivlauncher-cn)                | ![MPR package](https://repology.org/badge/version-for-repo/mpr/xivlauncher-cn.svg?header=MPR)                                                                                                                                                       |
| [PRM (Fedora+Opensuse)](https://github.com/bamdragonfly/lure-repo)                    | ![RPM package](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fraw.githubusercontent.com%2Fbamdragonfly%2Flure-repo%2Fmaster%2Fxivlauncher-cn%2Fversion.json&query=%24.version&prefix=v&label=RPM&color=pink)                           |
| [Chiyuki-Overlay (Gentoo)](https://github.com/IllyaTheHath/gentoo-overlay)            | ![Ebuild package](https://img.shields.io/badge/dynamic/xml?url=https%3A%2F%2Fraw.githubusercontent.com%2FIllyaTheHath%2Fgentoo-overlay%2Fmaster%2Fgames-util%2Fxivlauncher-cn%2Fversion.xml&query=%2F%2Fversion&prefix=v&label=Ebuild&color=6E56AF) |
