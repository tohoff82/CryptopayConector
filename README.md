# CryptopayConnetor
C# API wrapper for CryptoPay https://telegra.ph/Crypto-Pay-API-11-25

How to use this CryptoPay API connector?

<code>Install-Package CryptoPay.Conector -Version 0.0.1</code>

1. Add CryptoPay to your dependency container

```
services.AddCryptopay(new ConnectorOpts 
{
       ApiUrl = "testNet or mainNet url here",
    ApiToken  = "you App Token here"
});

```

2. Inject CryptoPay conector into you service

```
public class ConectorService
{
    private readonly IPayConector _conector;

    public ConectorService(IPayConector conector)
    {
        _conector = conector;
    }
}

```

3. Call the required method

```
var answer = await _conector.GetMeAsync();

```

You can thank here <code> <b>--></b> [Mono Bank donate](https://send.monobank.com.ua/NNG8cy25) "</code> or here <code> <b>--></b> [TON donate](https://t.me/CryptoBot?start=IVzvtl4RU4q8) "</code>
