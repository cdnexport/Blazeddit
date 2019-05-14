using System;

namespace Blazeddit.Shared
{
    public interface IJsonSerializable<T>
    {
        T Json(string from);

        T[] JsonArr(string from);
    }
}