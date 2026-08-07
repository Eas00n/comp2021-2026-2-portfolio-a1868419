using Xunit;

namespace TodoApp.Tests;

public class PersonTests
{
    [Fact]
    public void FullName_ReturnsExpectedFormat()
    {
        Person person = new Person("Yuchen", "Lu", 20);

        Assert.Equal("Lu, Yuchen", person.FullName());
    }

    [Fact]
    public void IsAdult_ReturnsTrue_WhenAge18OrMore()
    {
        Person person = new Person("Yuchen", "Lu", 20);

        Assert.True(person.IsAdult());
    }
}