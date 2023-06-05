using EspacioEmpleado;
internal class Program
{
    
    private static void Main(string[] args)
    {
        double salario1, salario2, salario3, salario4;
        int añosJub1, añosJub2, añosJub3;
        Empleado empleado1 = new Empleado("Enzo","Peralta",new DateTime(1996,05,30),'s','M',new DateTime(2005,01,01),150000,cargos.Ingeniero);
        Empleado empleado2 = new Empleado("Jimena","Amado",new DateTime(1990,12,18),'c','F',new DateTime(2000,08,21),100000,cargos.Aministrativo);
        Empleado empleado3 = new Empleado("Sofia","Gramajo",new DateTime(2002,08,1),'s','F',new DateTime(2021,01,01),120000,cargos.Investigador);
        Empleado empleado4 = new Empleado("Nombre","Apellido",new DateTime(1990,01,01),'c','M',new DateTime(2008,01,01),65000,cargos.Especialista);
        
        salario1=empleado1.Salario();
        Console.WriteLine("Concepto: Salario1 || Monto:"+salario1);
        salario2=empleado2.Salario();
        Console.WriteLine("Concepto: Salario2 || Monto:"+salario2);
        salario3=empleado3.Salario();
        Console.WriteLine("Concepto: Salario3 || Monto:"+salario3);
        salario4 = empleado4.Salario();
        Console.WriteLine("Concepto: Salario4 || Monto:"+salario4);
        double SalarioTotal = salario1+salario2+salario3;

        Console.WriteLine("Concepto: Salario || Monto Total:"+SalarioTotal);

        añosJub1 = empleado1.AñosJubilacion();
        Console.WriteLine("Concepto: Jubilacion1 || Años faltantes:"+añosJub1);
        añosJub2 = empleado2.AñosJubilacion();
        Console.WriteLine("Concepto: Jubilacion2 || Años faltantes:"+añosJub2);
        añosJub3 = empleado3.AñosJubilacion();
        Console.WriteLine("Concepto: Jubilacion3 || Años faltantes:"+añosJub3);

       if (añosJub1 <= añosJub2 && añosJub1 <= añosJub3)
       {
            MostrarDatosEmpleado(empleado1);
       }else
       {
        if (añosJub2<=añosJub1 && añosJub2<=añosJub3)
        {
            MostrarDatosEmpleado(empleado2);
        }else
        {
            MostrarDatosEmpleado(empleado3);
        }
       }
       

    }

    public static void MostrarDatosEmpleado(Empleado empleado){
        Console.WriteLine("***** Datos del empleado *****");
        Console.WriteLine("Nombre:"+empleado.Nombre+","+empleado.Apellido);
        Console.WriteLine("Fecha de Nacimiento:"+empleado.FechaNac.ToString("dd/MM/yyyy")+"|| Edad:"+empleado.Edad());
        if (empleado.EstadoCivil=='s')
        {
            Console.WriteLine("Estado civil:Soltero || Genero:"+empleado.Genero);
        }else
        {
            Console.WriteLine("Estado civil:Casado || Genero:"+empleado.Genero);
        }
        Console.WriteLine("Fecha de ingreso:"+empleado.FechaIngreso.ToString("dd/MM/yyyy"));
        Console.WriteLine("Antiguedad:"+empleado.Antiguedad());
        Console.WriteLine("Años restante para jubilacion:"+empleado.AñosJubilacion());
        Console.WriteLine("Cargo:"+empleado.Cargo+" "+"Basico $"+empleado.SueldoBasico);
        Console.WriteLine("Salario:"+empleado.Salario());
        Console.WriteLine("----------------------------------------");
    }
    
}