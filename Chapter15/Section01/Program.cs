// See https://aka.ms/new-console-template for more information
List<IGreetingBase> list = [
    new GreetingMorning(),
    new GreetingAfternoon(),
    new GreetingEvening(),
    ];

foreach (var obj in list) {
    string msg = obj.GetMessage();
    Console.WriteLine(msg);
}
//インターフェース
interface IGreetingBase {
    public virtual string GetMessage() => "";
}

//GreetingBaseを実装したクラス群
class GreetingMorning : IGreetingBase {
    public string GetMessage() => "おはよう";
}

class GreetingAfternoon : IGreetingBase {
    public string GetMessage() => "こんにちは";
}

class GreetingEvening : IGreetingBase {
    public string GetMessage() => "こんばんは";
}
