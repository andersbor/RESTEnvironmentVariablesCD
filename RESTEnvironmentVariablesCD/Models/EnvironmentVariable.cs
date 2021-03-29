namespace RESTEnvironmentVariablesCD.Models
{
    public class EnvironmentVariable
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public EnvironmentVariable(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return Key + ":" + Value;
        }
    }
}
