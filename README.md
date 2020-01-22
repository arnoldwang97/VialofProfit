# IncursionUniqueProfit

IncursionUniqueProfit is a tool that lists the profits that a player can make if he purchases the base item and vial that can be sacrificed in the tier 3 Temple of Atzoatal Room - Apex of Ascension. Profit is calculated with
```
Profit = Price of Upgraded Unique - Cost of Vial - Cost of Base Item
```
based on current market prices. Market prices are obtained by using
* [poe.watch/api](https://poe.watch/api)

This tool is helpful in 2 theoretical scenarios:

1. The player has a T3 Sacrifice Chamber and does not have use for any of the resulting items
2. The player has many Alva missions stocked in the Atlas

## Installation
The only contents you need to run the application are
* [here](https://github.com/arnoldwang97/IncursionUniqueProfit/tree/master/IncursionProfitMacro/Application)
This application is built in C#, so as of now the `.exe` only runs if you have the local `.dll` files (potential bugfix for the future)

## Usage
Run `IncursionUniqueProfit.exe` with the `.dll` files in the same folder. The result should look similar to
(dependent on market prices)
![Example Image](/readmeExample.png)

## References
Images and market data property of Grinding Gear Games
