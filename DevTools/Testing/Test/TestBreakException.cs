using System;

namespace DevTools.Testing;

public class TestBreakException(string message) : Exception(message);