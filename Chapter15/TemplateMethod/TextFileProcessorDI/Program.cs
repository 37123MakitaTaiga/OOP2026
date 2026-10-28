using TextFileProcessorDI;

var service = new LineCounterService();
var processor = new TextFileProcessor(service);
Console.WriteLine("パスの入力：");
    processor.Run(Console.ReadLine());