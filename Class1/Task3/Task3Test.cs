using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task3.Task3;

namespace Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(0.1), Is.EqualTo(1.0).Within(1e-5));
        That(F(-1.0), Is.EqualTo(0.0).Within(1e-5));
        That(F(1.5), Is.EqualTo(-1.0).Within(1e-5));
        That(F(3.0), Is.EqualTo(-1.0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(2020), Is.EqualTo(366));
        That(NumberOfDays(2000), Is.EqualTo(366));
        That(NumberOfDays(1300), Is.EqualTo(365));
        That(NumberOfDays(1303), Is.EqualTo(365));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(40), Is.EqualTo("сорок лет"));
        That(AgeDescription(21), Is.EqualTo("двадцать один год"));
        That(AgeDescription(69), Is.EqualTo("шестьдесят девять лет"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}