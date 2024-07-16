# Morpion / TicTacToe

[![forthebadge](http://forthebadge.com/images/badges/built-with-love.svg)](https://learn.microsoft.com/fr-fr/dotnet/csharp/tour-of-csharp/)  [![forthebadge](https://forthebadge.com/images/badges/license-mit.svg)](LICENSE)

A little project in C# and .NET where you could play with a friend or against an IA

# To start | Build the executable

## Using Visual Studio
Open Your Project in Visual Studio:

- Launch Visual Studio.
- Open your .NET project by selecting File > Open > Project/Solution and navigating to your project file (.csproj).

- Set the Output Type:
Right-click on your project in the Solution Explorer and select Properties.
Go to the Application tab.
Ensure the Output type is set to Console Application or Windows Application depending on your project type.

- Build the Project:
Click on Build in the menu bar and select Build Solution or press Ctrl+Shift+B.

- Locate the Executable:
Once the build is successful, you can find the .exe file in the bin\Debug\net5.0 (or net6.0, etc., depending on your target framework) directory of your project.


## Using the .NET CLI
- Open Command Prompt or Terminal:
- Navigate to Your Project Directory:
Use the cd command to navigate to the directory containing your .csproj file.

- Publish the Project:

Use the dotnet publish command to build your project and produce an executable.
```bash
dotnet publish -c Release -r win-x64 --self-contained
```

Here:
-c Release specifies that the build configuration is Release (you can use Debug if needed).
-r win-x64 specifies the target runtime (you can change it based on your target OS, e.g., win-x86, linux-x64, osx-x64).
--self-contained includes the .NET runtime with your application, making it self-contained.
Locate the Executable:

- The output will be in the bin\Release\net5.0\win-x64\publish directory (adjust paths as per your framework and runtime).

## Start

Launch the executable file and enjoy the TicTacToe.

You could find many options in the StripMenu :
- DarkMode
- IA vs Player | Player vs Player
- IADifficulty : Easy(facile) or Hard(difficile)

## Made with 

- C#
- .NET 8.0
- Windows.Forms

## Programmer

* **Clément Nuttens** _alias_ [@ClemNTTS](https://github.com/ClemNTTS)

## License
This project is under the ``MIT License`` - loock at the file [LICENSE.md](LICENSE) for more informations