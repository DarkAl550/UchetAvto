using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UchetAvto
{
    class Validate
    {
        public string TextValid(string text)
        {
            char[] words = text.ToArray();
            char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] chars = { '~', '!', '@', '#', '$', '%', '^', '&', '?', '*', '"', '(', ')', '-', '_', '+', '=', '/', ' ', '<', '>', '.', ',', '|', '\\' };
            foreach (char w in words)
            {
                if (nums.Contains(w)) return null;
                if (chars.Contains(w)) return null;
            }
            if (text == "" || text == null) return null;
            return text;
        }
        public string CheckNumFields(string field)
        {
            try
            {
                double f = double.Parse(field);
                return field;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string CheckTimeField(string time)
        {
            char[] times = time.ToArray();
            if (times.Contains(':')) return time;
            return null;
        }

        public string CheckEmail(string email)
        {
            char[] symbols = email.ToArray();
            if (symbols.Contains('@') && symbols.Contains('.')) return email;
            return null;
        }
        public string CheckNewUsername(string username)
        {
            char[] words = username.ToArray();
            char[] chars = { '~', '!', '@', '#', '$', '%', '^', '&', '?', '*', '"', '(', ')', '-', '_', '+', '=', '/', ' ', '<', '>', '.', ',', '|', '\\' };
            foreach (char w in words)
            {
                if (chars.Contains(w)) return null;
            }
            return username;
        }
        public string CheckComboBoxValue(object[] allValues, string selectedValues)
        {
            if (allValues.Contains(selectedValues)) return selectedValues;
            return null;
        }
        
    }
}
