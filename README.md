# LinWin

*A way to help people switch to Windows.*

## What is it?

LinWin is a Linux terminal Simulator made in C#.

## Todo

- [x] ls command
- [ ] cd command
- [x] help command
- [ ] man command
- [ ] WSL intergration
- [ ] apt recreation

## Installation

LinWin doesn't have an official installer yet, so here's how to use it.

### Requirements

- Visual Studio 2022 with .Net 8.0
- NuGet

### Steps

1. Download the "develop" branch's source code using `git clone https://github.com/mimmeer-github/LinWin.git`,
2. Open the downloaded project in Visual Studio 2022,
     - Or use the command prompt go go into the downloaded project.
     - Type in `nuget restore LinWin.sln & dotnet build`
     - Skip number 3 and go to number 4
4. Start building it by clicking `Build` > `Build Solution` or clicking the green play button,
5. Check `[LinWin Zip file]\bin\Debug\net8.0` and double-click `LinWin.exe` to open it if it didn't open already.
