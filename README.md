![xlcore_sized](https://user-images.githubusercontent.com/16760685/197423373-b6082cdb-dc1f-46db-8768-3f507f182ba8.png)

# XIVLauncher.Core

XIVLauncher 的跨平台版本，针对 Steam Deck 进行了优化。 附带一个 [为最终幻想14调整过的 WINE](https://github.com/goatcorp/wine-xiv-git).

[反馈频道](https://qun.qq.com/qqweb/qunpro/share?_wv=3&_wwv=128&inviteCode=CZtWN&from=181074&biz=ka&shareSource=5)

## 在 Steam Deck 上使用

如果您想在 Steam Deck 上使用 XIVLauncher，请随时[按照我们常见问题解答中的指南](https://aonyx.ffxiv.wang/faq/steamdeck)。 如果您遇到问题，可以[加入我们的反馈频道]([https://discord.gg/3NMcUV5](https://qun.qq.com/qqweb/qunpro/share?_wv=3&_wwv=128&inviteCode=CZtWN&from=181074&biz=ka&shareSource=5)) - 请不要使用 GitHub issues 进行故障排除，除非您确定您的问题是与 XIVLauncher 的代码相关。

## Building & Contributing
1. Clone this repository with submodules
2. Make sure you have a recent(.NET 6.0.400+) version of the .NET SDK installed
2. Run `dotnet build` or `dotnet publish`

Common components that are shared with the Windows version of XIVLauncher are linked as a submodule in the "lib" folder. XIVLauncher Core can run on Windows, but is by far not as polished as the [original Windows version](https://github.com/goatcorp/FFXIVQuickLauncher). Windows users should not use this application unless for troubleshooting purposes or development work.

## 分发
XIVLauncher Core 具有适用于各种 Linux 发行版的社区包。 请注意，**只有 Flathub 版本是官方版本**，但其他版本是由社区成员**打包**。 社区包可能并不总是最新的，或者可能有损坏的版本或包含正在测试的功能（特别是如果标记为不稳定或 git）。 我们对其安全性或可靠性不承担任何责任。

| 仓库        | 状态      |
| ----------- | ----------- |
<<<<<<< HEAD
| [**Flathub (official)**](https://flathub.org/apps/details/cn.ottercorp.xivlaunchercn) | ![Flathub](https://img.shields.io/flathub/v/cn.ottercorp.xivlaunchercn) |
| [AUR](https://aur.archlinux.org/packages/xivlauncher-cn-git) | ![AUR version](https://img.shields.io/aur/version/xivlauncher-cn-git) |
| [MPR (Debian+Ubuntu)](https://mpr.makedeb.org/packages/xivlauncher-cn)  | ![MPR package](https://repology.org/badge/version-for-repo/mpr/xivlauncher-cn.svg?header=MPR) |
| [PRM (Fedora+Opensuse)](https://github.com/bamdragonfly/lure-repo)  | ![RPM package](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fraw.githubusercontent.com%2Fbamdragonfly%2Flure-repo%2Fmaster%2Fxivlauncher-cn%2Fversion.json&query=%24.version&prefix=v&label=RPM&color=pink)|
| [Chiyuki-Overlay (Gentoo)](https://github.com/IllyaTheHath/gentoo-overlay)  | ![Ebuild package](https://img.shields.io/badge/Ebuild-1.0.3.1-6E56AF) |
=======
| [**Flathub (official)**](https://flathub.org/apps/details/dev.goats.xivlauncher) | ![Flathub](https://img.shields.io/flathub/v/dev.goats.xivlauncher) |
| [AUR](https://aur.archlinux.org/packages/xivlauncher) | ![AUR version](https://img.shields.io/aur/version/xivlauncher) |
| [AUR (git)](https://aur.archlinux.org/packages/xivlauncher-git) | ![AUR version](https://img.shields.io/aur/version/xivlauncher-git) |
| [Copr (Fedora+openSuse+EL9)](https://copr.fedorainfracloud.org/coprs/rankyn/xivlauncher/) | ![COPR version](https://img.shields.io/endpoint?url=https%3A%2F%2Fraw.githubusercontent.com%2Frankynbass%2FXIVLauncher4rpm%2Fmain%2Fbadge.json)|
| [GURU (Gentoo)](https://gitweb.gentoo.org/repo/proj/guru.git/tree/games-util/xivlauncher) | ![GURU version](https://repology.org/badge/version-for-repo/gentoo_ovl_guru/xivlauncher.core.svg?header=guru) |
| [MPR (Debian+Ubuntu)](https://mpr.makedeb.org/packages/xivlauncher)  | ![MPR package](https://repology.org/badge/version-for-repo/mpr/xivlauncher.core.svg?header=MPR) |
| [MPR (git) (Debian+Ubuntu)](https://mpr.makedeb.org/packages/xivlauncher-git)  | ![MPR package](https://repology.org/badge/version-for-repo/mpr/xivlauncher.core.svg?header=MPR) |
| [nixpkgs stable](https://search.nixos.org/packages?channel=23.11&from=0&size=50&sort=relevance&type=packages&query=xivlauncher) | ![nixpkgs stable version](https://repology.org/badge/version-for-repo/nix_stable_23_11/xivlauncher.core.svg?header=nixpkgs%2023.11) |
| [nixpkgs unstable](https://search.nixos.org/packages?channel=unstable&from=0&size=50&sort=relevance&type=packages&query=xivlauncher) | ![nixpkgs unstable version](https://repology.org/badge/version-for-repo/nix_unstable/xivlauncher.core.svg?header=nixpkgs%20unstable) |
| [PPA (Ubuntu)](https://launchpad.net/~linneris/+archive/ubuntu/xivlauncher-core-stable) | ![PPA version](https://img.shields.io/static/v1?label=PPA&message=1.0.5&color=brightgreen) |
>>>>>>> main
