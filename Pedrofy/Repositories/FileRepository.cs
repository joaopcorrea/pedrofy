using System.Text;
using System.Text.Json;

namespace Pedrofy.Repository
{
    public static class FileRepository
    {
        public static void CheckFiles()
        {
            if (!File.Exists("history.json"))
            {
                using var fs = File.Create("history.json");
                byte[] info = new UTF8Encoding(true).GetBytes("[]");
                fs.Write(info, 0, info.Length);
            }
        }

        public static T ReadFile<T>(string file)
        {
            using var reader = new StreamReader(file);
            var json = reader.ReadToEnd();
            if (string.IsNullOrEmpty(json))
                return default(T);

            var data = JsonSerializer.Deserialize<T>(json);
            return data;
        }

        public static void WriteFile<T>(string file, T value)
        {
            using var writer = new StreamWriter(file);
            var json = JsonSerializer.Serialize(value);
            writer.Write(json);
        }
    }
}
