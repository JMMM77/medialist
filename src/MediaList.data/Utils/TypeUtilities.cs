namespace MediaList.Data.Utils;

public static class TypeUtilities
{
    public static List<T?> GetAllPublicConstantValues<T>(this Type type)
    {
        return type.GetFields().Select(x => (T?)x.GetRawConstantValue()).ToList();
    }
}
