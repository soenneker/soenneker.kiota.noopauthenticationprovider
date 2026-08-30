[![](https://img.shields.io/nuget/v/soenneker.kiota.noopauthenticationprovider.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.kiota.noopauthenticationprovider/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.kiota.noopauthenticationprovider/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.kiota.noopauthenticationprovider/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.kiota.noopauthenticationprovider/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.kiota.noopauthenticationprovider/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.kiota.noopauthenticationprovider.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.kiota.noopauthenticationprovider/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.kiota.noopauthenticationprovider/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.kiota.noopauthenticationprovider/actions/workflows/codeql.yml)

# Soenneker.Kiota.NoOpAuthenticationProvider

A Kiota authentication provider for clients that intentionally send requests without credentials.

## Install

```bash
dotnet add package Soenneker.Kiota.NoOpAuthenticationProvider
```

## Usage

```csharp
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Kiota.NoOpAuthenticationProvider;

var adapter = new HttpClientRequestAdapter(
    new NoOpAuthenticationProvider(),
    httpClient: httpClient);
```

The provider satisfies Kiota's authentication dependency without adding or changing request headers. Use it for public APIs or when another handler applies authentication. It does not remove credentials already present on a request.
