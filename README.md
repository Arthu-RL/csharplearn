```sh
dotnet build csharp.csproj
```

```sh
dotnet exec ./bin/Debug/net8.0/linux-x64/csharp.dll
```

```sh
dotnet run
```

```sh
dotnet run --arch "amd64" --os "linux" --project "csharp.csproj"
```

```sh
dotnet run --no-build --no-restore --arch "amd64" --os "linux" --project "csharp.csproj"
```

```sh
dotnet test csharp.csproj
```