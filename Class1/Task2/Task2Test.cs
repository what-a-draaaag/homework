using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(2, 0, 0), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(0, 2, -1), Is.EqualTo(-1));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(0, 2, -1), Is.EqualTo(2)); 
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(2, 2, -1), Is.EqualTo(2));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(0, 2, 1), Is.EqualTo(2));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI));
        That(Deg2Rad(900.0), Is.EqualTo(Math.PI * 5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180).Within(1e-5));
    }

    [Test]
    public void MoreRadDegTests()
    {
        That(Rad2Deg(2*Math.PI), Is.EqualTo(360).Within(1e-5));
        That(Rad2Deg(4 * Math.PI), Is.EqualTo(4 * 180).Within(1e-5));
        That(Rad2Deg(3*Math.PI), Is.EqualTo(3*180).Within(1e-5));
        That(Rad2Deg(6 * Math.PI), Is.EqualTo(6 * 180).Within(1e-5));
        That(Rad2Deg(1.5*Math.PI), Is.EqualTo(1.5*180).Within(1e-5));
        That(Deg2Rad(360.0), Is.EqualTo(2*Math.PI));
        That(Deg2Rad(180.0*3), Is.EqualTo(Math.PI * 3));
        That(Deg2Rad(180.0*4), Is.EqualTo(Math.PI*4));
        That(Deg2Rad(180*6), Is.EqualTo(Math.PI * 6));
        That(Deg2Rad(180.0*1.5), Is.EqualTo(Math.PI*1.5));
    }
}