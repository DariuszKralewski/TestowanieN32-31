using System;

namespace Aplikacja
{
    public class DemeritPointCalculator
    {
        private const int SpeedLimit = 50; // Prędkość graniczna w km/h
        private const int MaxSpeed = 300; // Maksymalna prędkość w km/h
        private const int PointsPer5KmOverLimit = 1; // Punkty karne za każde 5 km/h powyżej limitu

        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0 || speed > MaxSpeed)
                throw new ArgumentOutOfRangeException(nameof(speed), $"Prędkość musi być w zakresie od 0 do {MaxSpeed} km/h.");

            if (speed <= SpeedLimit)
                return 0; // Brak punktów karnych, jeśli prędkość jest w granicach limitu

            int excessSpeed = speed - SpeedLimit;
            int demeritPoints = (excessSpeed / 5) * PointsPer5KmOverLimit;
            return demeritPoints;
        }
    }
}
