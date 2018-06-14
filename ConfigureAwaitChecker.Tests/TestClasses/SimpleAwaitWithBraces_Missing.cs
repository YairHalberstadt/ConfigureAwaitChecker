﻿using System.Threading.Tasks;
using ConfigureAwaitChecker.Tests;
using ConfigureAwaitChecker.Tests.TestClasses;

[CheckerTests.ExpectedResult(new[] { true })]
public class SimpleAwaitWithBraces_Missing : TestClassBase
{
	public async Task FooBar()
	{
		await (Task.Delay(1));
	}
}
