# HyBe
Hypance Backend
# Tüm Fonksiyonlar UserId ile ilişkili olup olmadıkları kontrol edilecek, eğer değillerse User ile ilişkilendirilecek.
## Favorite Coin

1- User-Coin mapping tablosu oluşturulacak.
UserId = Guid, CoinId = Guid.
2- Bunun için MemberController oluşturulacak. 
İçinde yer alan fonksiyonlar: AddUserFavoriteCoin, RemoveUserFavoriteCoin, GetListFavoriteCoin
Bunlar için application ve services katmanında ilgili classlar oluşturulacak.
## Open Trades

1- GetListOpenTrades fonksiyonu TransactionControllerına eklenecek.
Çalışma Mantığı: Transaction tablosunda IsCompleted=false olanlar gelecek. 
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
