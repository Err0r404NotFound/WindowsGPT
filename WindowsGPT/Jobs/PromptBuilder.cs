using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsGPT.Jobs
{
    class PromptBuilder
    {
        public static string GeneratePrompt(string solicitud, string ejemplo)
        {
            // Componer el prompt completo
            StringBuilder promptBuilder = new StringBuilder();
            promptBuilder.AppendLine("Act as a C# expert")
                         .AppendLine("Instructions: Provide the following code in C# language for the following request:")
                         .AppendLine($"Request: '{solicitud}'")
                         .AppendLine()
                         .AppendLine("Example Code:")
                         .AppendLine(ejemplo)
                         .AppendLine()
                         .AppendLine("RULES: The response must contain only the requested code, without including 'using' or any additional text, and without that period you put at the beginning, just CODE");


            return promptBuilder.ToString();
        }
    }
}
