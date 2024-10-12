> [!WARNING]
> This is not a serious project and as such may have flaws and bugs<br>
> If you are looking for a good password generator, you might want to look elsewhere

# About
Secure Password Generator is a simple program that lets you generate up to 128 passwords with up to 1024 random characters<br>
I made this in my free time over the course of a few hours

<p align="center"><img src="Screenshots/Image1.png"></p>

# Features
- Security Setting <br>
  - Low Security - Uses C#'s [`Random`](https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0) class<br>
  - Medium Security - Uses [Xorshift32](https://en.wikipedia.org/wiki/Xorshift), a very fast, linear PRNG<br>
  - High Security - Uses C#'s [`RandomNumberGenerator`](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.randomnumbergenerator?view=net-8.0) class, a cryptographically secure RNG
- Password Length (2 - 1024)
  - A higher count can help Medium Security's PRNG as it seeds itself
  - It is recommended not to go beyond 64 characters when using High Security
- Password Count (1 - 128)
  - Generates a whole new password, which can also help Medium Security's PRNG
  - It is recommended not to go beyond 3 passwords when using High Security
- Generation Iterations
  - Number of times to use the PRNG. A higher count can help Medium Security's PRNG as it seeds itself
  - It is recommended not to go beyond 1 iteration when using High Security

# Requirements
> [!NOTE]
> These are the bare minimum that support this program. I recommend going for more recent releases
- (Minimum) Windows 7 SP1
- (Minimum) Windows Server 2008 R2 SP1
- [.NET 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)
