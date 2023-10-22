# HyBe
Hypance Backend

## Strategies

1- Sadece o kullanıcının StrategyId ve strateji ismini dönen bir fonksiyon yazılacak. 

2- Aşağıdaki alanları döndüren bir fonksiyon yazılacak.  
IMyStrategy{
    id:number,
    name:string,
    description:string,
    orderSignal:string,
    interval:string,
    indicator:string,
    period:number,
    value:number,
    provision:string,
    crossingIndicator:string,
    crossingIndicatorPeriod:number,
}

3- Yukarıdaki alanların güncellenmesi için bir fonksiyon yazılacak.

4- StrategyController'da yer alan Create fonksiyonu yukarıdaki modele göre güncellenecek, şu an sadece name ve description var.
## Bot

1- BotController'ın Create fonksiyonu aşağıda yer alan modele göre güncellenecek.
ICreateBot{
    name:string,
    description:string,
    predefinedMarket:string,
    priceStrategy:number,
    tradeType:string,
    assets:string,
    strategy:string,
    formation:string,
    trendStrategy:string,
    priceVolume:number,
}

2- BotController'ın Update fonksiyonu da aynı şekilde güncellenecek.


## Front-end tablo yapısına göre gerekli verilerin diğer tablolardan çekme işlemi yapılacak.
