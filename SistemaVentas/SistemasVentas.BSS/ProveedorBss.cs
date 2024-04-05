using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.BSS;
using SistemaVentas.Modelos;

namespace SistemasVentas.BSS
{
    public  class ProveedorBss
    {
        ProveedorDal dal = new ProveedorDal();
        public DataTable ListarProveedorBss()
        {
            return dal.ListarProveedorDal();
        }
        public void InsertarPorveedorBss(Proveedor proveedor)
        {
            dal.InsertarProveedorDal(proveedor);
        }
        public Proveedor ObtenerProveedorIdBss(int id)
        {
            return dal.ObtenerProveedorIdDal(id);
        }
        public void EditarProveedorBss(Proveedor proveedor)
        {
            dal.EditarProveedorDal(proveedor);
        }
        public void EliminarProveedorBss(int id)
        {
            dal.EliminarProveedorDal(id);
        }
    }
}
