﻿using System.Collections.Generic;
using System.Linq;

namespace GuestBook.Helpers
{
    public static class CollectionExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection == null || !collection.Any();
        }
    }
}
