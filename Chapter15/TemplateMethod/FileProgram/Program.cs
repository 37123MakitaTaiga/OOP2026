using System.Text.RegularExpressions;
using TextFileProcessor;


string path = @"C:\Users\infosys\Documents\２０２６年１０月２８日.txt";
TextProcessor.Run<LineCounterProcessor>(path);


public class LineCounterProcessor : TextProcessor {

    protected override void Execute(string line) {
        string converted = Regex.Replace(
            line,
            "[０-９]",
            m => ((char)(m.Value[0] - '０' + '0')).ToString());

        Console.WriteLine(converted);
    }
}