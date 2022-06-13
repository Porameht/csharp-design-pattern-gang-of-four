using Newtonsoft.Json;

namespace csharp_design_pattern_gang_of_four
{
    public class Memento<T>
    {
        public string Type { get; }
        private readonly string _serializeData;
        public T Object => JsonConvert.DeserializeObject<T>(_serializeData);

        public Memento(T serializeObject) {
            Type = typeof(T).ToString();
            _serializeData = JsonConvert.SerializeObject(serializeObject);

        }
        
    }
    
}