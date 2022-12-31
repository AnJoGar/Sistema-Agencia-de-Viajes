using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data;
namespace Capa_Negocio
{
    public class N_users
    {


        D_users objd = new D_users();

        public DataTable N_user(E_users obje)
        {
            return objd.D_user(obje);
        }

        

       
    }
}
