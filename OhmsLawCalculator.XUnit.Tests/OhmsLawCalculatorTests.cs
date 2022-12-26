namespace OhmsLawCalculator.XUnit.Tests;

public class OhmsLawCalculatorTests
{
    [Fact]
    public void Given_Zero_Resistance_Value_When_CalculateCurrent_Then_Throw_Divide_By_Zero_Exception()
    {
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => OhmsLawCalculator.CalculateCurrent(5, 0));
    }

    [Fact]
    public void Given_Zero_Current_Value_When_CalculateResistance_Then_Throw_Divide_By_Zero_Exception()
    {
        // Act (Example of a split action to store the act block)
        Action act = () => OhmsLawCalculator.CalculateResistance(5, 0);

        // Assert
        Assert.Throws<DivideByZeroException>(act);
    }

    [Theory]
    [InlineData(0, 0, 2)]
    [InlineData(0, 1, 0)]
    public void Given_Any_Zero_Argument_Value_When_CalculateVoltage_Then_Return_Zero(float expectedVoltage, float current, float resistance)
    {
        // Act
        var actualVoltage = OhmsLawCalculator.CalculateVoltage(current, resistance);

        // Assert
        Assert.Equal(expectedVoltage, actualVoltage);
    }

    [Theory]
    [InlineData(-1, 1)]
    [InlineData(1, -1)]
    [InlineData(-1, -1)]
    public void Given_A_Negative_Argument_Value_When_CalculateVoltage_Then_Throw_An_Argument_Exception(float current, float resistance)
    {
        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => OhmsLawCalculator.CalculateVoltage(current, resistance));

        // Verify the exception message
        Assert.Equal("Invalid arguments. Argument numbers must be positive.", exception.Message);
    }

    [Theory]
    [InlineData(-1, 1)]
    [InlineData(1, -1)]
    [InlineData(-1, -1)]
    public void Given_A_Negative_Argument_Value_When_CalculateCurrent_Then_Throw_An_Argument_Exception(float voltage, float resistance)
    {
        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => OhmsLawCalculator.CalculateCurrent(voltage, resistance));

        // Verify the exception message
        Assert.Equal("Invalid arguments. Argument numbers must be positive.", exception.Message);
    }

    [Theory]
    [InlineData(-1, 1)]
    [InlineData(1, -1)]
    [InlineData(-1, -1)]
    public void Given_A_Negative_Argument_Value_When_CalculateResistance_Then_Throw_An_Argument_Exception(float voltage, float current)
    {
        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => OhmsLawCalculator.CalculateResistance(voltage, current));

        // Verify the exception message
        Assert.Equal("Invalid arguments. Argument numbers must be positive.", exception.Message);
    }

    [Theory]
    [InlineData(0, 0, 2)]
    [InlineData(0, 1, 0)]
    [InlineData(1, 1, 1)]
    [InlineData(2, 1, 2)]
    public void Given_Valid_Arguments_When_CalculateVoltage_Then_Return_A_Correct_Voltage(float expectedVoltage, float current, float resistance)
    {
        // Act
        var actualVoltage = OhmsLawCalculator.CalculateVoltage(current, resistance);

        // Assert
        Assert.Equal(expectedVoltage, actualVoltage);
    }

    [Theory]
    [InlineData(0, 0, 2)]
    [InlineData(1, 1, 1)]
    [InlineData(0.5, 1, 2)]
    public void Given_Valid_Arguments_When_CalculateCurrent_Then_Return_A_Correct_Current(float expectedCurrent, float voltage, float resistance)
    {
        // Act
        var actualCurrent = OhmsLawCalculator.CalculateCurrent(voltage, resistance);

        // Assert
        Assert.Equal(expectedCurrent, actualCurrent);
    }

    [Theory]
    [InlineData(0, 0, 2)]
    [InlineData(1, 1, 1)]
    [InlineData(0.5, 1, 2)]
    public void Given_Valid_Arguments_When_CalculateResistance_Then_Return_A_Correct_Resistance(float expectedResistance, float voltage, float current)
    {
        // Act
        var actualResistance = OhmsLawCalculator.CalculateResistance(voltage, current);

        // Assert
        Assert.Equal(expectedResistance, actualResistance);
    }
}