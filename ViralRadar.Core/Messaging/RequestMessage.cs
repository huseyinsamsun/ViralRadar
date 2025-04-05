using System;
namespace ViralRadar.Core.Messaging
{
    public class RequestMessage
    {
        private readonly Dictionary<string, object> _payloads = new();

        public bool Success { get; set; }
        public string? Message { get; set; }
        public List<string>? Errors { get; set; }

        public void Add<T>(T data)
        {
            var key = typeof(T).FullName!;
            _payloads[key] = data!;
        }

        public T? Get<T>()
        {
            var key = typeof(T).FullName!;
            return _payloads.TryGetValue(key, out var value) ? (T)value : default;
        }

        public void AddList<T>(List<T> list)
        {
            var key = $"List<{typeof(T).FullName}>";
            _payloads[key] = list!;
        }

        public List<T>? GetList<T>()
        {
            var key = $"List<{typeof(T).FullName}>";
            return _payloads.TryGetValue(key, out var value) ? (List<T>)value : default;
        }

        public void Clear()
        {
            _payloads.Clear();
            Success = false;
            Message = null;
            Errors = null;
        }
    }
}

