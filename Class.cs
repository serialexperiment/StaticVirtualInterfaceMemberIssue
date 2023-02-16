namespace StaticVirtualInterfaceMemberIssue;

public class Class : IHaveStaticMethod
{
	public static void Method()
	{
		Console.WriteLine("Hello, world!");
	}
}

