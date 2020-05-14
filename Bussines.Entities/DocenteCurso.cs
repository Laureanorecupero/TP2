using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
   public class DocenteCurso:BusinessEntity
       
    {
        public DocenteCurso()
        {
            this.Cargo = TiposCargos.Tipo1;
        }
        private TiposCargos _Cargo;
        public TiposCargos Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        private int _IDCurso;

        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }
        private int _IDDocente;
        public int IDDocente
        {
            get { return _IDDocente; }
            set { _IDDocente = value; }
        }
        public enum TiposCargos
        {
            Tipo1,
            Tipo2,
            Tipo3,
            Tipo4
        }
    }
}
