using System.Reflection;
public class Reflection
{
	public static void TypeInfo<T>(T obj) where T: class
	{
		Type t = typeof(T);
		Console.WriteLine("\nType: {0}", t);
		Console.WriteLine("\nConstructors:");
		ConstructorInfo[] constructorsInfo = t.GetConstructors();
		foreach (ConstructorInfo constructorInfo in constructorsInfo) Console.WriteLine(constructorInfo.Name);

		Console.WriteLine("\nMethods:");
		MethodInfo[] methodsInfo = t.GetMethods();
		foreach (MethodInfo methodInfo in methodsInfo) Console.WriteLine(methodInfo.Name);

		Console.WriteLine("\nFields: ");
		FieldInfo[] fieldsInfo = t.GetFields();
		foreach (FieldInfo fieldInfo in fieldsInfo) Console.WriteLine(fieldInfo.Name);
	}
}
