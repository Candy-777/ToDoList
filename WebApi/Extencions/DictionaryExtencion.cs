using WebApi.Models;

namespace WebApi.Extencions
{
    public static class DictionaryExtencion
    {
        public static TaskItem GetRequiredValue(this Dictionary<int, TaskItem> dictionary, int key)
        {
            if (dictionary.TryGetValue(key, out var value))
            {
                return value;  
            }
            else
            {
                throw new KeyNotFoundException($"Task with ID {key} not found.");
            }
        }

        public static void EnsureKeyExists(this Dictionary<int, TaskItem> dictionary, int key)
        {
            if (!dictionary.ContainsKey(key))
            {
                throw new KeyNotFoundException($"Task with ID '{key}' does not exist.");
            }
        }
    }
}
