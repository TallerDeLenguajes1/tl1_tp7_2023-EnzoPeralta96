using System;
namespace EspacioEmpleado
{
    public enum cargos
    {
        Auxiliar = 1,
        Aministrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5
    }
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private cargos cargo;

        const int JubilacionM = 65;
        const int JubilacionF = 60;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        internal cargos Cargo { get => cargo; set => cargo = value; }


        public Empleado()
        {
        }

        public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico,cargos cargo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechaNac;
            this.EstadoCivil = estadoCivil;
            this.Genero = genero;
            this.FechaIngreso = fechaIngreso;
            this.SueldoBasico = sueldoBasico;
            this.Cargo = cargo;
        }

     
        public int Antiguedad(){
            DateTime fechaActual = DateTime.Now;
            int Antiguedad = fechaActual.Year - fechaIngreso.Year;
            if (fechaActual.Month < fechaIngreso.Month || (fechaActual.Month == fechaIngreso.Month && fechaActual.Day < fechaIngreso.Day))
            {
                Antiguedad--;
            }
            return Antiguedad;
        }

        public int Edad(){
            DateTime fechaActual = DateTime.Now;
            int anios = fechaActual.Year - fechaNac.Year;
            if (fechaActual.Month < fechaNac.Month || (fechaActual.Month == fechaNac.Month && fechaActual.Day < fechaNac.Day))
            {
                anios--;
            }
            return anios;
        }
        
        public int AñosJubilacion(){
           
            if (genero == 'M')
            {
                return (JubilacionM - Edad());
            }else
            {
                return (JubilacionF - Edad());
            }
        }

        public double Salario(){

            int Antiguedad1 = Antiguedad();
            double Adicional;
            
            if (Antiguedad1 < 20)
            {
                Adicional = (Antiguedad1*sueldoBasico)/100;
            }else
            {
                Adicional = (Antiguedad1*sueldoBasico)*(25/100);
            }
            if (cargo == cargos.Especialista || cargo==cargos.Ingeniero)
            {
                Adicional = Adicional + (Adicional*0.5);
            }
            if (estadoCivil=='c')
            {
                Adicional = Adicional + 15000;
            }

            return (Adicional + sueldoBasico);
        }


    }

    
}