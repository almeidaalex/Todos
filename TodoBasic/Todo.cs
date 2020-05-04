using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Todos
{
    public class Todo : IEquatable<Todo>
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("isComplete")]
        public bool IsComplete { get; set; }

        public bool Equals([DisallowNull] Todo other)
        {
            return this.Id == other.Id;
        }

        public override bool Equals(object obj) => Equals(obj as Todo);

        public override int GetHashCode() => Id.GetHashCode();
    }
}
