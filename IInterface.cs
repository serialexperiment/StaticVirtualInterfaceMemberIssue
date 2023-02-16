namespace StaticVirtualInterfaceMemberIssue;

public interface IInterface : IHaveStaticMethod
{
	static void IHaveStaticMethod.Method()
	{
		Console.WriteLine("Hello, world!");
	}
}

