using Exercise03;

var service = new Take20Processor();
var processor = new TextFileProcessor(service);
processor.Run(@"枕草子.txt");