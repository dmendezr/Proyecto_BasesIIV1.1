﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Votante
    {

        public static DataTable ObtenerVotante(String DatosSELECT, String DatosWhere)
        {

            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT "+DatosSELECT+" FROM dbo.Votante Vot JOIN dbo.CodElec as codE ON Vot.CodElec = codE.CodElec JOIN dbo.Canton as Cant ON Cant.codCanton = codE.codCanton JOIN dbo.Provincia as Prov ON Prov.codProvincia = codE.codProvincia WHERE "+DatosWhere+";";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        public static int InsertarVotante (string cedula, string codElec, string sexo, string fechaCaduc, string junta, string nombre, string apellido1, string apellido2)
        {
            SqlCommand _comando = MetodosDatos.InsertDeVotante(cedula,codElec,sexo,fechaCaduc,junta,nombre,apellido1,apellido2);
            return MetodosDatos.EjecutarProcedimientoAlmacenado(_comando);
        }
    }
}
