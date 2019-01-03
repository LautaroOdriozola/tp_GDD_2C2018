﻿using PalcoNet.DataBasePackage;
using PalcoNet.Editar_Publicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;


namespace PalcoNet.PublicacionesUtils
{
    public class Publicacion
    {
        public long id { get; set; }

        [DisplayName("Descripción")]
        public String descripcion { get; set; }

        [DisplayName("Fecha publicación")]
        public DateTime? fechaPublicacion { get; set; }

        [DisplayName("Fecha vencimiento")]
        public DateTime? fechaVencimiento { get; set; }

        [DisplayName("Fecha espectáculo")]
        public DateTime? fechaEspectaculo { get; set; }

        [DisplayName("Estado")]
        public Estado estado { get; set; }

        [DisplayName("Ciudad")]
        public String ciudad { get; set; }

        [DisplayName("Localidad")]
        public String localidad { get; set; }

        [DisplayName("Calle")]
        public String calle { get; set; }

        [DisplayName("Nro. calle")]
        public String nroCalle { get; set; }

        [DisplayName("C.P.")]
        public String codigoPostal { get; set; }

        public Rubro rubro = null;

        public Grado grado = null;

        [DisplayName("Rubro")]
        public String DescripcionRubro
        {
            get
            {
                return rubro != null ? rubro.Descripcion : "Sin rubro";
            }
        }

        [DisplayName("Grado")]
        public String DescripcionGrado
        {
            get
            {
                return grado != null ? grado.descripcion : "Sin grado";
            }
        }

        private int? _idEspectaculo = null;
        public int GetIdEspectaculo()
        {
            if (_idEspectaculo == null)
            {
                var dt = DataBase.GetInstance().Query("select COMPUMUNDOHIPERMEGARED.get_espectaculo_id_de_publicacion(" + this.id +") as value");
                _idEspectaculo = new DataRowExtended(dt.Rows[0]).IntValue("value");
            }
            return (int)this._idEspectaculo;
        }



        private List<Ubicacion> ubicaciones = null;
        public List<Ubicacion> Ubicaciones
        {
            get
            {
                if (ubicaciones == null)
                    ubicaciones = Ubicacion.FindUbicacionesDePublicacion(this.id);
                return ubicaciones;
            }
            set
            {
                ubicaciones = value;
            }
        }

        public static Publicacion FromDataRow(DataRow dr)
        {
            var publicacion = new Publicacion();
            var dataRow = new DataRowExtended(dr);

            publicacion.id = dataRow.LongValue("id_publicacion");
            publicacion.descripcion = dataRow.StringValue("descripcion");
            publicacion.fechaPublicacion = dataRow.OrElse<DateTime?>("fecha_publicacion", null);
            publicacion.fechaVencimiento = dataRow.OrElse<DateTime?>("fecha_vencimiento", null);
            publicacion.fechaEspectaculo = dataRow.OrElse<DateTime?>("fecha_espectaculo", null);
            publicacion.ciudad = dataRow.StringValue("ciudad");
            publicacion.localidad = dataRow.StringValue("localidad");
            publicacion.calle = dataRow.StringValue("dom_calle");
            publicacion.nroCalle = dataRow.StringValue("num_calle");
            publicacion.codigoPostal = dataRow.StringValue("cod_postal");
            publicacion.estado = Estados.Parse(dataRow.StringValue("estado"));
            SetRubro(publicacion, dataRow);
            SetGrado(publicacion, dataRow);
            publicacion._idEspectaculo = dataRow.IntValue("id_espectaculo");

            return publicacion;
        }

        private static void SetRubro(Publicacion p, DataRowExtended dr){
            try{
                var idrubro = dr.IntValue("rubro_id");
                var descripcion = dr.StringValue("rubro_descripcion");
                var rubro = new Rubro(idrubro, descripcion);
                p.rubro = rubro;
            }catch(Exception){
                Console.WriteLine("No se pudo encontrar rubro para la publicación " + p.id);
                p.rubro = null;
            }
        }

        public static void SetGrado(Publicacion p, DataRowExtended dr){
            try{
                var idGrado = dr.IntValue("grado_id");
                var descripcion = dr.StringValue("grado_descripcion");
                var comision = dr.DoubleValue("grado_comision");
                var eliminado = dr.BoolValue("grado_eliminado");
                p.grado = new Grado(idGrado, descripcion, comision, eliminado);
            }catch(Exception){
                Console.WriteLine("No se pudo encontrar grado para la publicación " + p.id);
                p.grado = null;
            }
        }

        public override string ToString()
        {
            return String.Format("Publicacion({0}, {1}, {2}, {3}, {4}, {5})",
                this.id, this.descripcion, this.fechaEspectaculo, this.rubro, this.grado, this.estado);
        }



        public bool PuedeModificarse()
        {
            return this.estado.PuedeModificarse();
        }

        public void UpdateBorrador(long empresaId)
        {
            if(!this.PuedeModificarse())
                throw new Exception("Esta publicación no puede modificarse");
            this.BorrarSectoresBorrador();
            DataBase.GetInstance()
                .Procedure("update_datos_borrador",
                              new NullableInParameter("descripcion", this.descripcion),
                              new NullableInParameter("fecha_espectaculo", this.fechaEspectaculo),
                              new NullableInParameter("ciudad", this.ciudad),
                              new NullableInParameter("localidad", this.localidad),
                              new NullableInParameter("dom_calle", this.calle),
                              new NullableInParameter("num_calle", GetNumeroCalle(this.nroCalle)),
                              new NullableInParameter("cod_postal", this.codigoPostal),
                              new NullableInParameter("empresa_id", empresaId),
                              new NullableInParameter("rubro_id", this.rubro != null ? rubro.id as int? : null),
                              new NullableInParameter("grado_id", this.grado != null ? grado.id as int? : null),
                              new ParametroIn("id_publicacion", this.id));
        }

        public void GuardarBorrador(long empresaId)
        {
            if (!this.PuedeModificarse())
                throw new Exception("Esta publicación no puede modificarse");
            var returnPar = new ParametroOut("publicacion_id_generado", SqlDbType.BigInt);

            this.estado = new Borrador();

            DataBase.GetInstance()
                .Procedure("crear_borrador",
                              new NullableInParameter("descripcion", this.descripcion),
                              new NullableInParameter("fecha_espectaculo", this.fechaEspectaculo),
                              new NullableInParameter("estado", this.estado.Codigo()),
                              new NullableInParameter("ciudad", this.ciudad),
                              new NullableInParameter("localidad", this.localidad),
                              new NullableInParameter("dom_calle", this.calle),
                              new NullableInParameter("num_calle", GetNumeroCalle(this.nroCalle)),
                              new NullableInParameter("cod_postal", this.codigoPostal),
                              new NullableInParameter("empresa_id", empresaId),
                              new NullableInParameter("rubro_id", this.rubro != null ? this.rubro.id as int? : null),
                              new NullableInParameter("grado_id", this.grado.id),
                              returnPar);
            this.id = (long)returnPar.valorRetorno;
            Console.WriteLine("Publicacion generada id: " + this.id);
        }

        private int? GetNumeroCalle(String s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void BorrarSectoresBorrador(){
            DataBase.GetInstance()
                .Query(@"delete from COMPUMUNDOHIPERMEGARED.Sector
                              where id_espectaculo = " + this.GetIdEspectaculo());
        }


        public void Publicarse(List<Sector> sectores)
        {
            DataBase.GetInstance().WithTransaction(() =>
            {
                Publicar(this, sectores, this.id);
            });
            this.estado = new Publicado();
        }

        // esto esta horrible porque si le pasas un null en el ultimo parametro se crea una nueva y si no no
        private static void Publicar(Publicacion publicacion, List<Sector> sectores, long? publicacionID)
        {
            var self = publicacion;
            var salida = new ParametroOut("id_publicacion_generado", SqlDbType.BigInt);
            DataBase.GetInstance()
                    .Procedure("publicar_fecha"
                    , new ParametroIn("fecha_creacion", Contexto.FechaActual)
                    , new ParametroIn("fecha_espectaculo", self.fechaEspectaculo)
                    , new ParametroIn("grado_id", self.grado.id)
                    , new ParametroIn("id_espectaculo", self.GetIdEspectaculo())
                    , new ParametroIn("id_publicacion", publicacionID == null ? (Object)DBNull.Value : (Object)publicacionID)
                    , salida);
            var unString = publicacionID == null ? "NULL" : publicacionID.ToString();
            Console.WriteLine("publicacionID = " + unString);

            var nuevoID = Convert.ToInt64(salida.valorRetorno);

            if (publicacionID != null && nuevoID != publicacionID)
                throw new Exception("Esto no tenía que pasar");

            Console.WriteLine("publicacion_id = " + nuevoID);
            DataBase.GetInstance()
                .Procedure("generar_ubicaciones_de", new ParametroIn("id_publicacion", nuevoID));
            
            self.estado = new Publicado();
        }

        public static void PublicarFechas(Publicacion publicacion, List<DateTime> fechas, List<Sector> sectores)
        {
            DataBase.GetInstance().WithTransaction(() =>
            {
                long? id = publicacion.id;
                foreach (DateTime fecha in fechas)
                {
                    publicacion.fechaEspectaculo = fecha;
                    Publicar(publicacion, sectores, id);
                    id = null;
                }
            });
        }

        public List<Ubicacion> GetUbicacionesDisponibles(TipoUbicacion tipoUbicacion = null, Pagina pagina = null)
        {
            if (pagina == null)
                pagina = new Pagina(1, 10);

            String where = "";
            if (tipoUbicacion != null)
                where = "where tipo_ubicacion_id = " + tipoUbicacion.id;

            var sql = String.Format(@"select * from COMPUMUNDOHIPERMEGARED.Ubicacion u
            inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion t on u.tipo_ubicacion_id = t.id_tipo_ubicacion
            and u.publicacion_id = {1} and ocupado = 0
            {0}
            order by precio desc, fila asc
            OFFSET " + pagina.FirstResultIndex() + " ROWS FETCH NEXT " + pagina.pageSize + " ROWS ONLY",
                     where, this.id);

            var dt = DataBase.GetInstance().Query(sql);

            var lista = new List<Ubicacion>();
            foreach (DataRow dr in dt.Rows)
            {
                lista.Add(Ubicacion.FromDataRow(dr));
            }
            return lista;
        }

        public List<Ubicacion> GetUbicacionesDisponiblesSinIncluir(TipoUbicacion tipoUbicacion, Pagina pagina, List<Ubicacion> carrito)
        {
            if (pagina == null)
                pagina = new Pagina(1, 10);

            String where = "";
            List<string> condiciones = new List<string>();
            if (tipoUbicacion != null)
                condiciones.Add(" tipo_ubicacion_id = " + tipoUbicacion.id);
            if (carrito != null && carrito.Count != 0)
            {
                string[] arr = carrito.Select(u => u.Id.ToString()).ToArray();
                var list = string.Join(",", arr);
                var condicion = String.Format("id_ubicacion not in ({0})", list);
                condiciones.Add(condicion);
            }

            if (condiciones.Count > 0)
            {
                where += "where ";
                var condicionMultiple = string.Join(" and ", condiciones.ToArray());
                where += condicionMultiple;
            }

            var sql = String.Format(@"select * from COMPUMUNDOHIPERMEGARED.Ubicacion u
            inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion t on u.tipo_ubicacion_id = t.id_tipo_ubicacion
            and u.publicacion_id = {1} and ocupado = 0
            {0}
            order by precio desc, fila asc
            OFFSET " + pagina.FirstResultIndex() + " ROWS FETCH NEXT " + pagina.pageSize + " ROWS ONLY",
                     where, this.id);

            var dt = DataBase.GetInstance().Query(sql);

            var lista = new List<Ubicacion>();
            foreach (DataRow dr in dt.Rows)
            {
                lista.Add(Ubicacion.FromDataRow(dr));
            }
            return lista;
        }
    }
   
}
