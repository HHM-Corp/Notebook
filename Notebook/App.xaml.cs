﻿namespace Notebook;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage(new MainViewModel());
	}
}
