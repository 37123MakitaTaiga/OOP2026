using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class Take20Processor : ITextFileService{

        public void Initialize(string fname) {; }

        public void Execute(string line) => Console.WriteLine(line);
        
        public void Terminate() {; }

    }
}
