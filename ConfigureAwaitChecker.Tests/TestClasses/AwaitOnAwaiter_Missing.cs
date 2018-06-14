﻿using System.Threading.Tasks;
using ConfigureAwaitChecker.Tests;
using ConfigureAwaitChecker.Tests.TestClasses;

[CheckerTests.ExpectedResult(new[] { true })]
public class AwaitOnAwaiter_Missing : TestClassBase
{
	public async Task FooBar()
	{
		var awaiter = F(6);
		await awaiter;
	}
}