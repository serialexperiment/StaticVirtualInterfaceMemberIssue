namespace StaticVirtualInterfaceMemberIssue;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnClicked(object sender, EventArgs e)
	{
		try
		{
			CallMethod<Class>(); //Works on both Windows and Android
			CallMethod<IInterface>(); //Throws exception on Android
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}

	private void CallMethod<T>() where T : IHaveStaticMethod
	{
		T.Method();
	}
}

