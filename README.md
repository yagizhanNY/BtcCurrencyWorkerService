## BTC Currency Service

#### API Source
For get current BTC currency using [this url.](https://blockchain.info/ticker)

API Response:

```json
{
  "USD" : {"15m" : 15856.31, "last" : 15856.31, "buy" : 15856.31, "sell" : 15856.31, "symbol" : "$"},
  "AUD" : {"15m" : 21834.03, "last" : 21834.03, "buy" : 21834.03, "sell" : 21834.03, "symbol" : "$"},
  "BRL" : {"15m" : 85492.48, "last" : 85492.48, "buy" : 85492.48, "sell" : 85492.48, "symbol" : "R$"},
  "CAD" : {"15m" : 20761.81, "last" : 20761.81, "buy" : 20761.81, "sell" : 20761.81, "symbol" : "$"},
  "CHF" : {"15m" : 14537.07, "last" : 14537.07, "buy" : 14537.07, "sell" : 14537.07, "symbol" : "CHF"},
  "CLP" : {"15m" : 1.196675737E7, "last" : 1.196675737E7, "buy" : 1.196675737E7, "sell" : 1.196675737E7, "symbol" : "$"},
  "CNY" : {"15m" : 105111.49, "last" : 105111.49, "buy" : 105111.49, "sell" : 105111.49, "symbol" : "¥"},
  "DKK" : {"15m" : 100292.76, "last" : 100292.76, "buy" : 100292.76, "sell" : 100292.76, "symbol" : "kr"},
  "EUR" : {"15m" : 13460.84, "last" : 13460.84, "buy" : 13460.84, "sell" : 13460.84, "symbol" : "€"},
  "GBP" : {"15m" : 12028.14, "last" : 12028.14, "buy" : 12028.14, "sell" : 12028.14, "symbol" : "£"},
  "HKD" : {"15m" : 122947.81, "last" : 122947.81, "buy" : 122947.81, "sell" : 122947.81, "symbol" : "$"},
  "INR" : {"15m" : 1183285.21, "last" : 1183285.21, "buy" : 1183285.21, "sell" : 1183285.21, "symbol" : "₹"},
  "ISK" : {"15m" : 2182938.44, "last" : 2182938.44, "buy" : 2182938.44, "sell" : 2182938.44, "symbol" : "kr"},
  "JPY" : {"15m" : 1669307.1, "last" : 1669307.1, "buy" : 1669307.1, "sell" : 1669307.1, "symbol" : "¥"},
  "KRW" : {"15m" : 1.767387798E7, "last" : 1.767387798E7, "buy" : 1.767387798E7, "sell" : 1.767387798E7, "symbol" : "₩"},
  "NZD" : {"15m" : 23082.45, "last" : 23082.45, "buy" : 23082.45, "sell" : 23082.45, "symbol" : "$"},
  "PLN" : {"15m" : 60473.59, "last" : 60473.59, "buy" : 60473.59, "sell" : 60473.59, "symbol" : "zł"},
  "RUB" : {"15m" : 1223630.39, "last" : 1223630.39, "buy" : 1223630.39, "sell" : 1223630.39, "symbol" : "RUB"},
  "SEK" : {"15m" : 137318.72, "last" : 137318.72, "buy" : 137318.72, "sell" : 137318.72, "symbol" : "kr"},
  "SGD" : {"15m" : 21413.11, "last" : 21413.11, "buy" : 21413.11, "sell" : 21413.11, "symbol" : "$"},
  "THB" : {"15m" : 480763.37, "last" : 480763.37, "buy" : 480763.37, "sell" : 480763.37, "symbol" : "฿"},
  "TRY" : {"15m" : 124602.62, "last" : 124602.62, "buy" : 124602.62, "sell" : 124602.62, "symbol" : "₺"},
  "TWD" : {"15m" : 452293.38, "last" : 452293.38, "buy" : 452293.38, "sell" : 452293.38, "symbol" : "NT$"}
}
```

You can change your current currency from:

```csharp
apiClient.GetCurrentCurrency("TRY");
```