# CryptopayConnetor
API wrapper for CryptoPay API https://telegra.ph/Crypto-Pay-API-11-25

How to use this CryptoPay API connector?

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
