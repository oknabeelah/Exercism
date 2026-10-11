using System;
using System.Text;

public static class Identifier
{
    public static bool IsLowercaseGreek(char value) => (value >= 'α' && value <= 'ω');
    
    // _ : discard pattern (any value that hasnt matched a previous one) ie _ when sets a condition to be followed when any of the above hasn't matched, similar to continue;

    public static string? HandleCharacter(char character, bool capitalizeNext) => character switch
    {
        ' ' => "_", // replace ' ' with '_'
        '-' => null, // remove '-'
        _ when char.IsControl(character) => "CTRL", // replace control chars with "CTRL"
        _ when IsLowercaseGreek(character) => null, // remove lowercase greek letters
        _ when !char.IsLetter(character) => null, // remove non letters
        _ => capitalizeNext ? char.ToUpper(character).ToString(): character.ToString() 
            // return resulting string(.ToUpper if capitalizeNext is true)
            // ternary conditional operator: condition ? valueIfTrue : valueIfFalse
    };

    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool capitalizeNext = false;

        foreach (char character in identifier) 
        {
            string? result = HandleCharacter(character, capitalizeNext);
            if (result is not null)
            {
                sb.Append(result);
            }

            capitalizeNext = (character == '-');
        }
        return sb.ToString();
    }
}

        // for (int i = 0; i < identifier.Length; i++)
        // {
        // // TASK 1 - Replace ' ' with '_'
        //     if (identifier[i] == ' ')
        //     {
        //         sb.Append('_');
        //         continue; // to stop checking this index in later conditions
        //     }
        // // TASK 2 - Replace control chars with "CTRL"
        //     if (char.IsControl(identifier[i]))
        //     {
        //         sb.Append("CTRL");
        //     }
        // //TASK 5 - Omit greek lower case letters
        //     if (IsLowercaseGreek(identifier[i]))
        //     {
        //         continue; // preventing T4 from appending the same greek lowercase chars
        //     }
        // // TASK 4 - Omit non letters
        //     else if (char.IsLetter(identifier[i]))
        //     {
        //         sb.Append(identifier[i]);
        //     }
        // // TASK 3 - Convert kebab-case to camelCase
        //     if (identifier[i] == '-')
        //     {
        //         if (i + 1 < identifier.Length) // check to prevent IndexOutOfRangeException
        //         {
        //             sb.Append(char.ToUpper(identifier[i+1]));
        //             i += 1; // to avoid duplicating char appended ToUpper()
        //         }
        //     }
        // }