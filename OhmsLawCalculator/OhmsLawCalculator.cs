namespace OhmsLawCalculator;

public class OhmsLawCalculator
{
    public static float CalculateVoltage(float current, float resistance)
    {
        ValidateNegativeArgumentValues(current, resistance);

        return  current * resistance;
    }

    public static float CalculateCurrent(float voltage, float resistance)
    {
        ValidateZeroArgumentValue(resistance);
        ValidateNegativeArgumentValues(voltage, resistance);

        return voltage / resistance;
    }

    public static float CalculateResistance(float voltage, float current)
    {
        ValidateZeroArgumentValue(current);
        ValidateNegativeArgumentValues(voltage, current);

        return voltage / current;
    }

    private static void ValidateZeroArgumentValue(float argumentValue)
    {
        if (argumentValue == 0) throw new DivideByZeroException();
    }

    private static bool HasAnyNegativeArgumentValue(params float[] argumentValues) => argumentValues.Any(x => x < 0);
    
    private static void ValidateNegativeArgumentValues(params float[] argumentValues)
    {
        if (HasAnyNegativeArgumentValue(argumentValues)) throw new ArgumentException("Invalid arguments. Argument numbers must be positive.");
    }
}
