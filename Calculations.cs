using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dose_Calculations
{
    
    public class CalculationsByWeight
    {
        public decimal ParaWeightToVolume250(decimal weight)
        {
            decimal total = (15 * weight * 5) / 250;
            return (Math.Round(total, 1));

        }

        public decimal ParaWeightToVolume120(decimal weight)
        {
            decimal total = (15 * weight * 5) / 120;
            return (Math.Round(total, 1));
        }

        public decimal IbuWeightToVolume100(decimal weight)
        {
            decimal total = (10 * weight * 5) / 100;
            return (Math.Round(total, 1));
        }

    }

    public class CalculationsByMg
    {
        public decimal ParaMgToVolume250(decimal dose)
        {
            decimal total = (dose * 5) / 250;
            return (Math.Round(total, 1));

        }

        public decimal ParaMgToVolume120(decimal dose)
        {
            decimal total = (dose * 5) / 120;
            return (Math.Round(total, 1));
        }

        public decimal IbuWeightToVolume100(decimal dose)
        {
            decimal total = (dose * 5) / 100;
            return (Math.Round(total, 1));
        }

    }
    public class CalculationsByVolume
    {
        public decimal ParaVolumeToWeight250(decimal volume)
        {
            decimal total = (volume * 250) / (15 * 5);
            return (Math.Round(total, 1));
        }

        public decimal ParaVolumeToWeight120(decimal volume)
        {
            decimal total = (volume * 120) / (15 * 5);
            return (Math.Round(total, 1));
        }

        public decimal IbuVolumeToWeight100(decimal volume)
        {
            decimal total = (volume * 100) / (10 * 5);
            return (Math.Round(total, 1));
        }
    }

    public class ConvertPara
    {
        public decimal Para250To120(decimal volume)
        {
            decimal total1 = (volume * 250) / (15 * 5);
            decimal total = (15 * total1 * 5) / 120;
            return (Math.Round(total, 1));
        }
        public decimal Para250ToIbu100(decimal volume)
        {
            decimal total1 = (volume * 250) / (15 * 5);
            decimal total = (10 * total1 * 5) / 100;
            return (Math.Round(total, 1));
        }
        public decimal Para120To250(decimal volume)
        {
            decimal total1 = (volume * 120) / (15 * 5);
            decimal total = (15 * total1 * 5) / 250;
            return (Math.Round(total, 1));
        }

    }

    public class ManualCalculation
    {
        public decimal Manualcalculations(decimal dose, decimal bodyWeight, decimal strength)
        {
            decimal totalDose = (dose * bodyWeight);
            decimal total = (totalDose * 5) / strength;
            return (Math.Round(total, 1));
        }
    }
}
