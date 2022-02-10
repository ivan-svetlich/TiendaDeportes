using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

namespace TiendaDeportes
{
    #region Producto
    [Serializable]
    public class Producto
    {
        internal string categoria;
        internal string descripcion;
        internal string marca;
        internal string talle;
        internal string color;
        internal double precio;
        internal double descuento;
        internal string[] categorias = new string[] { "Genérico", "Calzado", "Ropa" };
        //internal bool promocion;

        public string Categoria { get => categoria; }
        public string Descripcion { get => descripcion; }
        public string Marca { get => marca; }
        public string Talle { get => talle; }
        public string Color { get => color; }
        public double Precio { get => precio; }
        public double Descuento { get => descuento; set => descuento = value; }
        public string[] Categorias { get => categorias; }

        public Producto(string categoria,string descripcion,string marca,string talle,string color,double precio)
        {
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.marca = marca;
            this.talle = talle;
            this.color = color;
            this.precio = precio;
            this.descuento = 0;
        }
        public double PrecioFinal()
        {
            return this.Precio * (1 - this.Descuento / 100);
        }

        public static List<string> GetTallesCalzado()
        {
            List<string> listaTalles = new List<string>();

            for (double talle = 14; talle <= 49; talle += 0.5)
            {
                listaTalles.Add(talle.ToString("0.0"));
            }

            return listaTalles;
        }

        public static List<string> GetTallesRopa()
        {
            List<string> listaTalles = new List<string>(new string[] { "XS", "S", "M", "L", "XL" });
            return listaTalles;
        }

        public static List<string> GetColores()
        {
            List<string> listaColores = new List<string>();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfos = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo propInfo in propInfos)
            {
                listaColores.Add(propInfo.Name);
            }
            return listaColores;
        }
    }
    #endregion Producto

    #region Cliente
    [Serializable]
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private DateTime nacimiento;
        private double totalGastado;

        internal string Nombre { get => nombre; }
        internal string Apellido { get => apellido; }
        internal int Dni { get => dni; }
        internal DateTime Nacimiento { get => nacimiento; }
        internal double TotalGastado { get => totalGastado; }

        public Cliente(string nombre,
                       string apellido,
                       int dni,
                       DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nacimiento = nacimiento;
            this.totalGastado = 0;
        }

        public void ActualizarTotalGastado(double nuevoGasto)
        {
            this.totalGastado += nuevoGasto;
        }

        public double GetTotalGastado()
        {
            return this.TotalGastado;
        }
    }
    #endregion Cliente

    #region FormaPago
    [Serializable]
    public class FormaPago
    {
        int cuotas;
        double interes;
        double interesConBeneficio;
        bool beneficio;

        public int Cuotas { get => cuotas; set => cuotas = value; }
        public double Interes { get => interes; set => interes = value; }
        public bool Beneficio { get => beneficio; set => beneficio = value; }
        public double InteresConBeneficio { get => interesConBeneficio; set => interesConBeneficio = value; }
    }
    #endregion FormaPago

    #region Tarjeta
    [Serializable]
    public class Tarjeta
    {
        string nombre;
        string banco;
        //List<FormaPago> formasPago;
        List<FormaPago> formasPago = new List<FormaPago>();
        double totalVendido;

        public string Nombre { get => nombre; }
        public string Banco { get => banco; }
        //public List<FormaPago> FormasPago { get => formasPago; }
        public double TotalVendido { get => totalVendido; }
        public List<FormaPago> FormasPago { get => formasPago; set => formasPago = value; }

        public FormaPago FormaPago
        {
            get => default;
            set
            {
            }
        }

        public Tarjeta(string nombre, string banco)
        {
            this.nombre = nombre;
            this.banco = banco;
            this.totalVendido = 0;
        }
        public int AddFormaPago(int cuotas, double interes)
        {
            bool yaExiste = false;
            for(int i = 0; i < this.FormasPago.Count; i++)
            {
                if(this.FormasPago[i].Cuotas==cuotas && this.FormasPago[i].Interes == interes)
                {
                    yaExiste = true;
                }
            }
            if (!yaExiste)
            {
                this.FormasPago.Add(new FormaPago() { Cuotas = cuotas, Interes = interes, InteresConBeneficio = interes, Beneficio = false });
                return 1;
            }
            else
            {
                return -1;
            } 
        }
        public int AddBeneficio(int index, double beneficio)
        {
            try
            {
                this.FormasPago[index].InteresConBeneficio = beneficio;
                this.FormasPago[index].Beneficio = true;
                return 1;
            }
            catch
            {
                return -1;
            }     
        }
        public int RemoveBeneficio(int index)
        {
            try
            {
                this.FormasPago[index].InteresConBeneficio = this.FormasPago[index].Interes;
                this.FormasPago[index].Beneficio = false;
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public bool TieneBeneficio()
        {
            bool beneficio = false;
            foreach(FormaPago fp in this.FormasPago)
            {
                if (fp.Beneficio)
                {
                    beneficio = true;
                }
            }
            return beneficio;
        }
        public void ActualizarTotalVendido(double nuevaVenta)
        {
            this.totalVendido += nuevaVenta;
        }
    }
    #endregion Tarjeta

    #region Carro
    [Serializable]
    public class Carro
    {
        List<Producto> listaProductos;

        public List<Producto> ListaProductos { get => listaProductos; }

        public Producto Productos
        {
            get => default;
            set
            {
            }
        }

        public Carro()
        {
            listaProductos = new List<Producto>();
        }

        public void Agregar(Producto producto, int cantidad)
        {
            for(int c = 1; c <= cantidad; c++)
            {
                this.listaProductos.Add(producto);
            }
        }

        public void Quitar(Producto producto)
        {
            this.listaProductos.Remove(producto);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach(Producto producto in this.listaProductos)
            {
                total += producto.PrecioFinal();
            }
            return total;
        }
    }
    #endregion Carro

    #region Compra
    [Serializable]
    public class Compra
    {
        Cliente cliente;
        Carro carro;
        Tarjeta tarjeta;
        FormaPago formaPago;

        public Cliente Cliente { get => cliente; }
        public Carro Carro { get => carro; }
        public Tarjeta Tarjeta { get => tarjeta; }
        public FormaPago FormaPago { get => formaPago; }

        public Carro Carro1
        {
            get => default;
            set
            {
            }
        }

        public Cliente Cliente1
        {
            get => default;
            set
            {
            }
        }

        public Tarjeta Tarjeta1
        {
            get => default;
            set
            {
            }
        }

        public FormaPago FormaPago1
        {
            get => default;
            set
            {
            }
        }

        public Compra()
        {
            this.carro = new Carro();
        }

        public void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }
        public void SetTarjeta(Tarjeta tarjeta)
        {
            this.tarjeta = tarjeta;
        }
        public void SetFormaPago(FormaPago formaPago)
        {
            this.formaPago = formaPago;
        }

        public double PrecioFinal()
        {
            return this.carro.CalcularTotal() * (1 + this.formaPago.InteresConBeneficio/100);
        }

    }
    #endregion Compra

    #region Tienda
    [Serializable]
    public class Tienda
    {
        List<Producto> listaProductos = new List<Producto>();
        List<Cliente> listaClientes = new List<Cliente>();
        List<Tarjeta> listaTarjetas = new List<Tarjeta>();
        Compra compra;
        double totalVendido;
        List<string> categorias = new List<string>(new string[] { "Genérico", "Calzado", "Ropa" });
        

        public List<Producto> ListaProductos { get => listaProductos; }
        public List<Cliente> ListaClientes { get => listaClientes; }
        public List<Tarjeta> ListaTarjetas { get => listaTarjetas; }
        public Compra Compra { get => compra; }
        public double TotalVendido { get => totalVendido; }

        public Tienda()
        {
            this.totalVendido = 0;
            this.compra = null;
        }

        public void AddProducto(Producto producto)
        {
            this.ListaProductos.Add(producto);
        }

        public void AddCliente(Cliente cliente)
        {
            this.listaClientes.Add(cliente);
        }

        public void AddTarjeta(Tarjeta tarjeta)
        {
            this.listaTarjetas.Add(tarjeta);
        }

        public void NuevaCompra()
        {
            this.compra = new Compra();
        }
        
        public void FinalizarCompra()
        {
            double precioFinal = this.compra.PrecioFinal();

            this.totalVendido += precioFinal;
            this.compra.Cliente.ActualizarTotalGastado(precioFinal);
            this.compra.Tarjeta.ActualizarTotalVendido(precioFinal);
            this.compra = new Compra();
        }

        public List<string> CategoriasProducto()
        {
            return categorias;
        }

        public int NuevoProducto(string categoria, string descripcion, string marca, string talle, string color, double precio )
        {
            try
            {
                Producto producto = new Producto(categoria, descripcion, marca, talle, color, precio);
                ListaProductos.Add(producto);
                return 1;
            }
            catch
            {
                return -1;
            }
            
        }
        public int NuevaTarjeta(string nombre, string banco)
        {
            try
            {
                Tarjeta tarjeta = new Tarjeta(nombre, banco);
                tarjeta.AddFormaPago(1, 0);
                ListaTarjetas.Add(tarjeta);
                return 1;
            }
            catch
            {
                return -1;
            }

        }

        public int AddPromo(int indice, double descuento)
        {
            try
            {
                ListaProductos[indice].Descuento = descuento;
                return 1;
            }
            catch
            {
                return -1;
            }
        }
    }
    #endregion Tienda

    #region BaseDatos
    public static class BaseDatos
    {
        public static void Guardar(Tienda tienda)
        {
            FileStream flujo = new FileStream("tienda.bin", FileMode.Create);
            BinaryFormatter escritor = new BinaryFormatter();

            escritor.Serialize(flujo, tienda);

            flujo.Close();
        }

        public static Tienda Cargar()
        {
            Tienda miTienda = new Tienda();

            if (File.Exists("tienda.bin"))
            {
                FileStream flujo = new FileStream("tienda.bin", FileMode.Open);
                BinaryFormatter lector = new BinaryFormatter();

                if(flujo.Length != 0)
                {
                    miTienda = (Tienda)lector.Deserialize(flujo);
                }

                flujo.Close();
            }
            else
            {
                File.Create("tienda.bin").Dispose();
            }
            return miTienda;
        }
    }
    #endregion BaseDatos
}
