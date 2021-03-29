using System;
using System.Collections;
using System.Collections.Generic;
using RESTEnvironmentVariablesCD.Models;

namespace RESTEnvironmentVariablesCD.Managers
{
    public class EnvironmentVariablesManager
    {
        public List<EnvironmentVariable> GetAll()
        {
            IDictionary dictionary = Environment.GetEnvironmentVariables();
            List<EnvironmentVariable> result = new List<EnvironmentVariable>();
            foreach (DictionaryEntry entry in dictionary)
            {
                EnvironmentVariable variable =
                    new EnvironmentVariable((string)entry.Key, (string)entry.Value);
                result.Add(variable);
            }
            return result;
        }

        public EnvironmentVariable GetByName(string name)
        {
            string value = Environment.GetEnvironmentVariable(name);
            if (value == null) return null;
            return new EnvironmentVariable(name, value);
        }
    }
}