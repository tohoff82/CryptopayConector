# CryptopayConector
C# API wrapper for CryptoPay [https://telegra.ph/Crypto-Pay-API-11-25](https://help.crypt.bot/crypto-pay-api)

How to use this CryptoPay API connector?

<code>[Install-Package CryptoPay.Conector -Version 1.0.0](https://www.nuget.org/packages/CryptoPay.Conector/)</code>

## 1 Use dependency injection

1.1 Add CryptoPay to your dependency container

```csharp
services.AddCryptopay(new CryptopayCredentials(
      apiUrl: "https://testnet-pay.crypt.bot/",
    apiToken: "9999:ABpPkivT2jiuVywaJbSGjfXFozOjQZfO3ZL"
));
```

2.1 Inject CryptoPay conector into you service & call the required method

```csharp
public class CryptopayService
{
    private readonly ICryptopay _cryptopay;

    public ConectorService(ICryptopay cryptopay)
    {
        _cryptopay = cryptopay;
    }
}
...

var answer = await _cryptopay.GetMeAsync();
```

## 2 Use simple initialization

2.1 Initialize CryptopayCredentials

```csharp
var creds = new CryptopayCredentials(
      apiUrl: "https://testnet-pay.crypt.bot/",
    apiToken: "9999:ABpPkivT2jiuVywaJbSGjfXFozOjQZfO3ZL"
);
```

2.2 Create connector instance & call the required method

```csharp
using var cryptopay = Connector.GetIstance(new HttpClient(), creds);

var answer = await cryptopay.GetMeAsync();
```

## You can thank here <code> <b>--></b> [Mono Bank donate](https://send.monobank.com.ua/NNG8cy25) "</code> or here <code> <b>--></b> [TON donate](https://t.me/CryptoBot?start=IVzvtl4RU4q8) "</code>
