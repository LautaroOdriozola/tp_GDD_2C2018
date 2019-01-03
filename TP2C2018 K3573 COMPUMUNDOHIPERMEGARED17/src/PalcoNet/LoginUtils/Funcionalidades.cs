﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.LoginUtils
{
    class Funcionalidades
    {
        public static List<Funcionalidad> findFuncionalidadesByRolId(int rolId)
        {
            String sql = String.Format("select * from COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_rol({0})", rolId);
            DataTable dt = DataBase.GetInstance().Query(sql);
            return funcionalidadesFromDataTable(dt);
        }

        public static List<Funcionalidad> findFuncionalidadesByUsuarioId(int usuarioId)
        {
            String sql = String.Format("select * from COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_usuario({0})", usuarioId);
            DataTable dt = DataBase.GetInstance().Query(sql);
            return funcionalidadesFromDataTable(dt);
        }

        public static List<Funcionalidad> TraerTodas() {
            return funcionalidadesFromDataTable(DataBase.GetInstance().Query("select * from COMPUMUNDOHIPERMEGARED.Funcionalidad"));
        }


        private static List<Funcionalidad> funcionalidadesFromDataTable(DataTable dt)
        {
            var funcionalidades = new List<Funcionalidad>();
            foreach (DataRow dr in dt.Rows)
            {
                funcionalidades.Add(Funcionalidad.traerDe(dr));
            }
            return funcionalidades;
        }
    }
}
