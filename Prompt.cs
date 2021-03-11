using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSearch
{
    static class Prompt
    {
        internal static string TextResponse(string toPrompt)
        {
            Console.Write(toPrompt);
            return Console.ReadLine();
        }

        internal static string TextResponse(string toPrompt, string withInvalidInputMessage, Func<string, bool> passCondition)
        {
            Console.WriteLine(toPrompt);
            var response = Console.ReadLine();
            while (!passCondition(response))
            {
                Console.WriteLine(withInvalidInputMessage);
                response = Console.ReadLine();
            }
            return response;
        }

        internal static int NumberResponse(string fromPrompt, string withErrorMessage)
        {
            Console.WriteLine(fromPrompt);
            int response;
            while (!int.TryParse(Console.ReadLine(), out response) || response < 0)
            {
                Console.WriteLine(withErrorMessage);
            }
            return response;
        }
    }
}
