![Repo-Image](https://druffko.gg/github-images/kaleidolib.webp)

<div align="center">

![GitHub release (latest by date including pre-releases)](https://img.shields.io/github/v/release/druffko/kaleidolib?include_prereleases)

![.NET Version](https://img.shields.io/badge/.NET-8.0-brightgreen)
![GitHub last commit](https://img.shields.io/github/last-commit/druffko/kaleidolib)
![Build status](https://img.shields.io/badge/build-passing-brightgreen)
![PRs](https://img.shields.io/badge/PRs-welcome-brightgreen)

  <br>

![GitHub All Releases](https://img.shields.io/github/downloads/druffko/kaleidolib/total)
![GitHub closed issues](https://img.shields.io/github/issues-closed/druffko/kaleidolib)
![GitHub issues](https://img.shields.io/github/issues/druffko/kaleidolib)

  <h1>Kaleidolib</h1>
  <p>
    Kaleidolib is a C# library providing different style additions for command line applications. This might sound pretty useless in the first place (probably because it is), but there might be some cases, where colors actually come in handy.
  </p>
</div>

---

## Table of Contents
- [About](#about)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

---

## About

Kaleidolib is a C# library providing different style additions for command line applications. This might sound pretty useless in the first place (probably because it is), but there might be some cases, where colors actually come in handy.

---

## Features

- ✅ Colors for Text in your CLI-Application
- ✅ Textstyles for Text in your CLI-Application
- ✅ Wrapper-Methods for easy usage

---

## Installation

### Download the latest version

To start off, please head to the [releases page](https://github.com/druffko/kaleidolib/releases) and download a pre-built dll.

*If you don't trust me for some reason, feel free to download the latest released source code and build it your self.*

### Import the library to your IDE/project

This process depends on the IDE, so just do it as it is done with your's.

---

## Usage

### Using colors
Colors can be used like this:

```csharp
Console.WriteLine(TextColors.red + "Look at what I can do!" + TextColors.reset);
Console.WriteLine(TextColors.bgred + "Look at what I can do!" + TextColors.reset);
```

### Using styles
Styles can be used like this:

```csharp
Console.WriteLine(TextStyles.bold + "Look at what I can do!" + TextStyles.reset);
Console.WriteLine(TextColors.underline + "Look at what I can do!" + TextColors.reset);
```

### Alternatively, you can use JKaleidolib's wrapper methods:

Colors:

```csharp
Console.WriteLine(Color.blue("Ciao!"));
```

Backgrounds:

```csharp
Console.WriteLine(Background.red("Sain bainuu!"));
```

Formatting:

```csharp
Console.WriteLine(Formatting.bold("Halo!"));
```

Lining:

```csharp
Console.WriteLine(Lining.underline("Silaw!"));
```

This way, you can combine several stylings at once very easily:

```csharp
Console.WriteLine(Background.green(Lining.underline(Color.blue("Ndêwó!"))));
Console.WriteLine(Lining.strikethrough(Color.purple("Yassou!")));
```

---

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a new branch (`git checkout -b feature-name`)
3. Commit your changes (`git commit -m 'Add some feature'`)
4. Push to the branch (`git push origin feature-name`)
5. Open a pull request

---

## License

This project is licensed under the [MIT License](LICENSE).

---

## Contact

- **druffko** - [@druffko](https://twitter.com/druffko) - hi@druffko.gg
- **Project Link** - https://github.com/druffko/kaleidolib

Feel free to reach out if you have any questions or suggestions!