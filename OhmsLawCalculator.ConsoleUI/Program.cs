using Calculator = OhmsLawCalculator.OhmsLawCalculator;

namespace ConsoleCalculator;

internal class Program
{
    private static void Main(string[] args)
    {
        // Examples of usage of the Ohm's Law Calculator
        Console.WriteLine("Ohm's Law Calculator");
        Console.WriteLine("V = I x R");
        Console.WriteLine("V: Volgate (Volts)");
        Console.WriteLine("I: Current (Amps)");
        Console.WriteLine("R: Resistance (Ohms)");

        // Voltage
        float current = .5f;
        float resistance = 10;
        Console.WriteLine($"Calculate Voltage [V = I x R] with I={current}A and R={resistance}Ω => {Calculator.CalculateVoltage(current, resistance)}V (Volts)");
        
        // Current
        float voltage = 5;
        resistance = 10;
        Console.WriteLine($"Calculate Current [I = V / R] with V={voltage}V and R={resistance}Ω => {Calculator.CalculateCurrent(voltage, resistance)}A (Amps)");
        
        // Resistance
        voltage = 5;
        current = .5f;
        Console.WriteLine($"Calculate Resistance [R = V / I] with V={voltage}V and I={current}A => {Calculator.CalculateResistance(voltage, current)}Ω (Ohms)");
    }
}