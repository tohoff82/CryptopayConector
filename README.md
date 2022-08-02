# CryptopayConector
C# API wrapper for CryptoPay https://telegra.ph/Crypto-Pay-API-11-25

How to use this CryptoPay API connector?

<code>[Install-Package CryptoPay.Conector -Version 0.0.1](https://www.nuget.org/packages/CryptoPay.Conector/)</code>

## 1 Use dependency injection

1.1 Add CryptoPay to your dependency container

```
services.AddCryptopay(new ConnectorOpts 
{
       ApiUrl = "testNet or mainNet url here",
    ApiToken  = "you App Token here"
});
```

2.1 Inject CryptoPay conector into you service & call the required method

```
public class ConectorService
{
    private readonly IPayConector _conector;

    public ConectorService(IPayConector conector)
    {
        _conector = conector;
    }
}

...

var answer = await _conector.GetMeAsync();
```

## 2 Use simple initialization

2.1 Initialize CryptopayCredentials

```
var creds = new CryptopayCredentials(
      apiUrl: "https://testnet-pay.crypt.bot/",
    apiToken: "9999:ABpPkivT2jiuVywaJbSGjfXFozOjQZfO3ZL"
);
```

2.2 Create connector instance & call the required method

```
using var cryptopay = Connector.GetIstance(new HttpClient(), creds);

var answer = await cryptopay.GetMeAsync();
```

## You can thank here <code> <b>--></b> [Mono Bank donate](https://send.monobank.com.ua/NNG8cy25) "</code> or here <code> <b>--></b> [TON donate](https://t.me/CryptoBot?start=IVzvtl4RU4q8) "</code>
