using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace TaskScheduler;

public static class ConfigurationDumper
{
    public static void DumpConfiguration(IConfiguration configuration)
    {
        Console.WriteLine("Dumping configuration...");

        var configDictionary = new Dictionary<string, string>();
        FlattenConfiguration(configuration, configDictionary);

        string json = JsonSerializer.Serialize(configDictionary, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        Console.WriteLine(json);
    }

    private static void FlattenConfiguration(IConfiguration config, Dictionary<string, string> output, string parentPath = "")
    {
        foreach (var child in config.GetChildren())
        {
            var currentPath = string.IsNullOrEmpty(parentPath) ? child.Key : $"{parentPath}:{child.Key}";

            if (child.Value == null)
            {
                // If the node has no value, it's a branch, recurse
                FlattenConfiguration(child, output, currentPath);
            }
            else
            {
                output[currentPath] = child.Value;
            }
        }
    }
}
