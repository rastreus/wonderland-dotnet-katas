# wonderland-dotnet-katas

These are a collection of .NET (C#/F#)
[katas](http://en.wikipedia.org/wiki/Kata_%28programming%29) inspired by
[Lewis Carroll](http://en.wikipedia.org/wiki/Lewis_Carroll) and _Alice
in Wonderland_.

Originally created as Clojure katas:
[gigasquid/wonderland-clojure-katas](https://github.com/gigasquid/wonderland-clojure-katas)

Initially ported as F# katas:
[mathias-brandewinder/wonderland-fsharp-katas](https://github.com/mathias-brandewinder/wonderland-fsharp-katas)

![Alice and the tiny door](./images/alicedoor.gif)

>“Curiouser and curiouser!” 
>-- ― Lewis Carroll, Alice in Wonderland

## Install pre-requisites

You'll need to install [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) as a pre-requisite in order to do the katas.

[Visual Studio Code](https://code.visualstudio.com) with the [Ionide](https://ionide.io/) extension is recommended. Other .NET coding environments (JetBrains Rider, Visual Studio, etc.) should work, but have not been tested. YMMV

## How to Do the Katas

First, clone, fork or degit this repo. Each of the katas are in their own
directory and are self contained C# and F# projects.  You `cd`
into the project and run `dotnet test` to show the failing tests, then
complete the code to make the tests pass. Each project has the
instructions in its own _README.md_ file.

For example, to get started on the F# _alphabet-cipher_ kata first.

1. Clone, Fork or [degit](https://github.com/Rich-Harris/degit) this repo:
    * `npx degit rastreus/wonderland-dotnet-katas`
2. run `dotnet tool restore`
3. run `dotnet paket restore`
4. run `dotnet paket install`
5. cd `fsharp/alphabet-cipher/test`
6. run `dotnet test`
7. Check out the alphabet cipher instructions in its _README.md_ file.
8. Add code to the source file in `fsharp/alphabet-cipher/src` to make the tests pass.

## License

Copyright © 2022 Russell Dillin, [MIT License](LICENSE).

Copyright © 2015 Mathias Brandewinder, MIT License

Copyright © 2014 Carin Meier, Eclipse Public License 1.0
