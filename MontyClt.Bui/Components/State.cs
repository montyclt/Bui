using System;
using System.Diagnostics.CodeAnalysis;

namespace MontyClt.Bui.Components
{
    public sealed class State : IEquatable<State>
    {
        public static readonly State Primary = new State("primary");
        public static readonly State Secundary = new State("secundary");
        public static readonly State Success = new State("success");
        public static readonly State Warning = new State("warning");
        public static readonly State Danger = new State("danger");

        private readonly string _value;

        private State(string value)
        {
            _value = value;
        }

        public bool Equals([AllowNull] State other)
        {
            if (other == null)
                return false;

            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is State)
                return Equals(obj);

            return false;
        }

        public static bool operator ==(State a, State b)
        {
            if (a is null && b is null)
                return true;

            if (a is null)
                return false;

            if (b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(State a, State b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_value);
        }

        public override string ToString()
        {
            return _value;
        }
    }
}
