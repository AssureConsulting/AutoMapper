using System.Collections.Generic;

namespace AutoMapper.CollectionExtensions
{
    internal static class StackEx
    {
        public static bool TryPeek<T>(this Stack<T> stack, out T result)
        {
            if (stack == null || stack.Peek == null)
            {
                result = default;
                return false;
            }
            result = stack.Peek();
            return true;
        }
    }
}

