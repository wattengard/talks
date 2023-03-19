using System.Text.Json.Serialization.Metadata;

namespace MyPenguins;

public interface IStateManager 
{
    public void SetState<T>(string key, T value);
    public T GetState<T>(string key);
    public string DumpStateAsJson();
}

public class StateManager : IStateManager
{
    private System.Text.Json.JsonSerializerOptions jsonOptions = new System.Text.Json.JsonSerializerOptions {
        WriteIndented = true
    };
    private Dictionary<string, object?> Values = new Dictionary<string, object?>();
    public string DumpStateAsJson() => System.Text.Json.JsonSerializer.Serialize(Values, options: jsonOptions);

    public T GetState<T>(string key)
    {
        if (Values.ContainsKey(key)) {
            return (T)Values[key]!;
        } else {
            return default(T)!;
        }
    }

    public void SetState<T>(string key, T value)
    {
        if(Values.ContainsKey(key)) {
            Values[key] = value;
        } else {
            Values.Add(key, value);
        }
    }
}