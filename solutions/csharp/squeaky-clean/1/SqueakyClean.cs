using System;
using System.Text;
using System.Linq;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder myStringBuilder = new StringBuilder(identifier);
        StringBuilder sb = new StringBuilder();
        char[] greekAlphabetsLowercase = [ 'α', 'β', 'γ', 'δ', 'ε', 'ζ', 'η', 'θ', 'ι', 'κ', 'λ', 'μ', 'ν', 'ξ', 'ο', 'π', 'ρ', 'σ', 'τ', 'υ', 'φ', 'χ', 'ψ', 'ω'];
        
        for (int i = 0; i < myStringBuilder.Length; i++)
        {
        // TASK 1 - Replace ' ' with '_'
            if (myStringBuilder[i] == ' ')
            {
                sb.Append('_');
                continue; // to stop checking this index in later conditions
            }
        // TASK 2 - Replace control chars with "CTRL"
            if (char.IsControl(myStringBuilder[i]))
            {
                sb.Append("CTRL");
            }
        //TASK 5 - Omit greek lower case letters
            if (greekAlphabetsLowercase.Contains(myStringBuilder[i]))
            {
                continue; // preventing T4 from appending the same greek lowercase chars
            }
        // TASK 4 - Omit non letters
            else if (char.IsLetter(myStringBuilder[i]))
            {
                sb.Append(myStringBuilder[i]);
            }
        // TASK 3 - Convert kebab-case to camelCase
            if (myStringBuilder[i] == '-')
            {
                if (i + 1 < myStringBuilder.Length) // check to prevent IndexOutOfRangeException
                {
                    sb.Append(char.ToUpper(myStringBuilder[i+1]));
                    i += 1; // to avoid duplicating char appended ToUpper()
                }
            }
        }

        return sb.ToString();
    }
}
