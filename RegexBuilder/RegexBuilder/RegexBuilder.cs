using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Builder
{
    class RegexBuilder
    {
        /// <summary>
        /// Set RegexOptions quickly. Ease-of-use method for quickly setting values depending on checkbox checked values
        /// </summary>
        /// <param name="compiled">Should Regex be compiled?</param>
        /// <param name="cultureInvariant">Should Regex ignore culture variations?</param>
        /// <param name="ecmaScript">Should ECMA-script compliant behaviour be enabled?</param>
        /// <param name="explicitCapture">Should Explicit Capture be enabled so only named/numbered groups are captured?</param>
        /// <param name="ignoreCase">Should the Regex ignore case when determining a match?</param>
        /// <param name="ignorePatternWhiteSpace">Shoudl pattern whitespace be ignored?</param>
        /// <param name="multiLine">Should multiline mode be enabled?</param>
        /// <param name="none">Remove all other RegexOptions</param>
        /// <param name="rightToLeft">Should search be from right-to-left?</param>
        /// <param name="singleLine">Should . also match newlines?</param>
        /// <returns>RegexOptions object with selected items set</returns>
        public RegexOptions setOptions( bool compiled, bool cultureInvariant, bool ecmaScript, bool explicitCapture,
            bool ignoreCase, bool ignorePatternWhiteSpace, bool multiLine, bool none, bool rightToLeft, bool singleLine)
        {
            RegexOptions options = 0;

            if (none)
	        {
		        options = RegexOptions.None;
                return options;
	        }

            if (ecmaScript)
            {
                options |= RegexOptions.ECMAScript;
                // Options below set to false to prevent an exception being raised
                cultureInvariant = false;
                explicitCapture = false;
                ignorePatternWhiteSpace = false;
                rightToLeft = false;
                singleLine = false;
            }
            
            if (compiled)
	            options |= RegexOptions.Compiled;
            if (cultureInvariant)
	            options |= RegexOptions.CultureInvariant;
	        if (explicitCapture)
                options |= RegexOptions.ExplicitCapture;
            if (ignoreCase)
                options |= RegexOptions.IgnoreCase;
            if (ignorePatternWhiteSpace)
                options |= RegexOptions.IgnorePatternWhitespace;
            if (multiLine)
                options |= RegexOptions.Multiline;
            if (rightToLeft)
                options |= RegexOptions.RightToLeft;
            if (singleLine)
                options |= RegexOptions.Singleline;
            
            return options;
        }

        /// <summary>
        /// Convenience method to set RegexOptions
        /// </summary>
        /// <param name="options">A Dictionary of named RegexOptions and their values</param>
        /// <returns>The selected RegexOptions</returns>
        public RegexOptions setOptions(Dictionary<string, bool> options)
        {
            RegexOptions regexOptions = 0;

            foreach (KeyValuePair<string, bool> item in options)
            {
                string key = item.Key.ToLowerInvariant();

                switch (key)
                {
                    case "compiled":
                        regexOptions |= RegexOptions.Compiled;
                        break;
                    case "cultureinvariant":
                        regexOptions |= RegexOptions.CultureInvariant;
                        break;
                    case "ecmascript":
                        try
                        {
                            regexOptions |= RegexOptions.ECMAScript;
                        }
                        catch (Exception up)
                        {
                            throw up;
                        }
                        break;
                    case "explicitcapture":
                        regexOptions |= RegexOptions.ExplicitCapture;
                        break;
                    case "ignorecase":
                        regexOptions |= RegexOptions.IgnoreCase;
                        break;
                    case "ignorepatternwhitespace":
                        regexOptions |= RegexOptions.IgnorePatternWhitespace;
                        break;
                    case "multiline":
                        regexOptions |= RegexOptions.Multiline;
                        break;
                    case "none":
                        regexOptions = RegexOptions.None;
                        return regexOptions;
                    case "righttoleft":
                        regexOptions |= RegexOptions.RightToLeft;
                        break;
                    case "singleline":
                        regexOptions |= RegexOptions.Singleline;
                        break;
                    default:
                        throw new ArgumentException(string.Format("The parameter {0} is not supported", key));
                }
            } // end of foreach
            return regexOptions;
        }

        /// <summary>
        /// Cleans text from textbox before creating Regex
        /// </summary>
        /// <param name="regexText">The text pattern for the Regex</param>
        /// <returns></returns>
        public Regex GetRegex(string regexText)
        {
            return GetRegex(regexText, RegexOptions.None);
        }


        /// <summary>
        /// Cleans text from textbox before creating Regex
        /// </summary>
        /// <param name="regexText">The text pattern for the Regex</param>
        /// <param name="options">The selected RegexOptions</param>
        /// <returns></returns>
        public Regex GetRegex(string regexText, RegexOptions options)
        {
            try
            {
                regexText = regexText.Replace("\\", "\\\\");
                regexText = Regex.Unescape(regexText);
                Regex rgx = new Regex(regexText, options);
                return rgx;
            }
            catch (Exception up)
            {
                throw up;
            }
            
        }
    }
}
