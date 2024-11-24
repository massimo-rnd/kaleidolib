![Repo-Image](https://massimo.gg/github-images/kaleidolib.webp)

<div align="center">

# Kaleidolib

![License](https://img.shields.io/github/license/massimo-rnd/kaleidolib)
![Issues](https://img.shields.io/github/issues/massimo-rnd/kaleidolib)
![Forks](https://img.shields.io/github/forks/massimo-rnd/kaleidolib)
![Stars](https://img.shields.io/github/stars/massimo-rnd/kaleidolib)
![Last Commit](https://img.shields.io/github/last-commit/massimo-rnd/kaleidolib)
![GitHub release (latest by date including pre-releases)](https://img.shields.io/github/v/release/massimo-rnd/kaleidolib?include_prereleases)

</div>

## 🚀 Overview

Kaleidolib is a C# library providing different style additions for command line applications. This might sound pretty useless in the first place (probably because it is), but there might be some cases, where colors actually come in handy.

## 🎯 Features

- Colors for Text in your CLI-Application
- Textstyles for Text in your CLI-Application
- Wrapper-Methods for easy usage

## 🛠️ Installation

### Download the latest version

To start off, please head to the [releases page](https://github.com/massimo-rnd/kaleidolib/releases) and download a pre-built dll.

*If you don't trust me for some reason, feel free to download the latest released source code and build it your self.*

### Import the library to your IDE/project

This process depends on the IDE, so just do it as it is done with your's.

## 💻 Usage

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

## 🚧 Roadmap

- [ ] Implement customizable Colors

Check out the [open issues](https://github.com/massimo-rnd/kaleidolib/issues) for more.

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!  
Feel free to check the [issues page](https://github.com/massimo-rnd/kaleidolib/issues).

1. Fork the project.
2. Create your feature branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a pull request.

See [CONTRIBUTING.md](CONTRIBUTING.md) for more details.

## 📜 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## 📊 Repository Metrics

![Repo Size](https://img.shields.io/github/repo-size/massimo-rnd/kaleidolib)
![Contributors](https://img.shields.io/github/contributors/massimo-rnd/kaleidolib)
![Commit Activity](https://img.shields.io/github/commit-activity/m/massimo-rnd/kaleidolib)

---

### 📞 Contact

For any inquiries, feel free to reach out:
- email: [hi@massimo.gg](mailto:hi@massimo.gg)
- X: [massimo-rnd](https://x.com/massimo-rnd)
- [Discord](https://discord.gg/wmC5AA6c)