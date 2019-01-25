using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_seguridad_social
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario");

            int Salario = int.Parse(Console.ReadLine());
            int SMMLV = 828116;
            double Pension;
            double EPS;

            double SalarioNeto;
            double SalarioAnual;

            double BaseCotizacion = Salario * 0.4;

            int TipoDeContrato = int.Parse(Console.ReadLine());

            //1 dependiente, 2 independiente

            if (BaseCotizacion <= SMMLV)
            {
                BaseCotizacion = SMMLV;

                Console.WriteLine("Ingrese tipo de contrato (1) dependiente, (2) independiente");

                if (TipoDeContrato == 1)
                {
                    Pension = (BaseCotizacion * 0.04);
                    EPS = (BaseCotizacion * 0.04);

                    SalarioNeto = Salario - Pension - EPS;
                    SalarioAnual = (SalarioNeto * 12) + Salario;


                }
                if (TipoDeContrato == 2)
                {
                    double ARL;
                    Pension = (Salario * 0.16);
                    EPS = (Salario * 0.125);

                    Console.WriteLine("Ingrese Riesgo del 1 al 5");

                    int Riesgo = int.Parse(Console.ReadLine());

                    if (Riesgo == 1)
                    {
                        ARL = BaseCotizacion * 0.00522;
                        SalarioNeto = Salario - Pension - EPS - ARL;
                        SalarioAnual = SalarioNeto * 12;
                    }
                    if (Riesgo == 2)
                    {
                        ARL = BaseCotizacion * 0.01044;
                        SalarioNeto = Salario - Pension - EPS - ARL;
                        SalarioAnual = SalarioNeto * 12;
                    }
                    if (Riesgo == 3)
                    {
                        ARL = BaseCotizacion * 0.02436;
                        SalarioNeto = Salario - Pension - EPS - ARL;
                        SalarioAnual = SalarioNeto * 12;
                    }
                    if (Riesgo == 4)
                    {
                        ARL = BaseCotizacion * 0.04350;
                        SalarioNeto = Salario - Pension - EPS - ARL;
                        SalarioAnual = SalarioNeto * 12;
                    }
                    if (Riesgo == 5)
                    {
                        ARL = BaseCotizacion * 0.06960;
                        SalarioNeto = Salario - Pension - EPS - ARL;
                        SalarioAnual = SalarioNeto * 12;
                    }

                }


            }
            BaseCotizacion = SMMLV;

            Console.WriteLine("Ingrese tipo de contrato (1) dependiente, (2) independiente");

            if (TipoDeContrato == 1)
            {
                Pension = (BaseCotizacion * 0.04);
                EPS = (BaseCotizacion * 0.04);

                SalarioNeto = Salario - Pension - EPS;
                SalarioAnual = (SalarioNeto * 12) + Salario;


            }
            if (TipoDeContrato == 2)
            {
                double ARL;
                Pension = (Salario * 0.16);
                EPS = (Salario * 0.125);

                Console.WriteLine("Ingrese Riesgo del 1 al 5");

                int Riesgo = int.Parse(Console.ReadLine());

                if (Riesgo == 1)
                {
                    ARL = BaseCotizacion * 0.00522;
                    SalarioNeto = Salario - Pension - EPS - ARL;
                    SalarioAnual = SalarioNeto * 12;
                }
                if (Riesgo == 2)
                {
                    ARL = BaseCotizacion * 0.01044;
                    SalarioNeto = Salario - Pension - EPS - ARL;
                    SalarioAnual = SalarioNeto * 12;
                }
                if (Riesgo == 3)
                {
                    ARL = BaseCotizacion * 0.02436;
                    SalarioNeto = Salario - Pension - EPS - ARL;
                    SalarioAnual = SalarioNeto * 12;
                }
                if (Riesgo == 4)
                {
                    ARL = BaseCotizacion * 0.04350;
                    SalarioNeto = Salario - Pension - EPS - ARL;
                    SalarioAnual = SalarioNeto * 12;
                }
                if (Riesgo == 5)
                {
                    ARL = BaseCotizacion * 0.06960;
                    SalarioNeto = Salario - Pension - EPS - ARL;
                    SalarioAnual = SalarioNeto * 12;
                }





            }
        }
    }
}
