# BlockchainWalletSharp
An unofficial C# library to interact with the Blockchain.info Wallet API V2.

## Documentation
Example code for initializing a ``BlockchainWallet`` instance
```cs
var blockchainWallet = new BlockchainWallet(new HttpClient(), new BlockchainWalletConfiguration
{
    Host = "http://localhost:3000",
    Identifier = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    Password = "xXxXxXxXxXxXxXxX"
});
```

Example code for sending a payment
```cs
var recipients = new Dictionary<string, long>
{
    { "1LaiteuxHEH4GsMC9aVmnwgUEZyrG6BiTH", 1337 }
};

var payment = await blockchainWallet.PaymentAsync(recipients, feePerByte: 50);

if (payment.Success)
{
    Console.WriteLine($"Payment successfully sent! TXID: {payment.TXID}");
}
else
{
    Console.WriteLine("An error occured while sending payment ...");
}
```

## Contribution
You're more than welcome if you want to fork this repo and submit a pull request!

## Donation
If you would like to support this project, please consider donating. Thank you!

- My Bitcoin address, if you allow me to lose your money at gambling: ``1LaiteuxHEH4GsMC9aVmnwgUEZyrG6BiTH``

- My girlfriend one, if you believe I should stay rich: ``1HefDd2P4LPtPQ46UCAhff9NdVgXVFB2x8``

## Contact
Telegram: [@Laiteux](https://t.me/Laiteux)

Instagram: [@eagle](https://instagr.am/eagle)

Email: matt@laiteux.dev

## License
This code is licensed under the MIT License.

## To-Do
- [ ] Handle Blockchain API errors & exceptions
- [ ] Switch to POST requests
